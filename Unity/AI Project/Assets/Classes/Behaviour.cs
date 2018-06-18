using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Behaviour : MonoBehaviour {

    public NavMeshAgent agent;
    public enum Needs {Idle, Energy, Hunger, Hygene, Thirst}
    public Needs needs;
    public GameObject food, water, bed, shower;
    public float energy, hunger, hygene, thirst;
    private float low = 75;

	void Start () {
        agent = GetComponent<NavMeshAgent> ();
	}
	
	void Update () {
        Needings ();
        Decay ();
	}

    void Decay () {

        energy -= 2 * Time.deltaTime;
        hunger -= 1 * Time.deltaTime;
        hygene -= 0.2f * Time.deltaTime;
        thirst -= 0.5f * Time.deltaTime;

        needs = Needs.Idle;

        if(energy <= low) {
            needs = Needs.Energy;
        }

        if(hunger <= low) {
            needs = Needs.Hunger;
        }

        if(hygene <= low) {
            needs = Needs.Hygene;
        }

        if(thirst <= low) {
            needs = Needs.Thirst;
        }

    }
    void Needings () {
        switch (needs) {

        case Needs.Idle:
        agent.SetDestination (Random.insideUnitSphere * 5 + transform.position);
        break;

        case Needs.Energy:
        agent.SetDestination (bed.transform.position);
        break;
        case Needs.Hunger:
        agent.SetDestination (food.transform.position);
        break;

        case Needs.Hygene:
        agent.SetDestination (shower.transform.position);
        break;

        case Needs.Thirst:
        agent.SetDestination (water.transform.position);
        break;

        }
    }
}
