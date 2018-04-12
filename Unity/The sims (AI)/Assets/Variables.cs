using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

    public float energy;
    public float hunger;
    public float hygene;
    private bool needEnergy;
    private bool needHunger;
    private bool needHygene;

    void Start () {
		
	}
	
	void Update () {
        UpdateVariables ();
	}

    void UpdateVariables () {
        energy -= 0.2f * Time.deltaTime;
        hunger -= 0.1f * Time.deltaTime;
        hygene -= 0.05f * Time.deltaTime;
        }
}
