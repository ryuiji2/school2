using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static PlayerStats instance;

    public float energy, hunger, hygene, thirst;

    public enum Needs { Idle, Energy, Hunger, Hygene, Thirst }

    void Awake() 
    {
        if(instance == null) {
            instance = this;
        }
    }
	
	void Start () 
    {
        StartCoroutine(Decay());
	}

    IEnumerator Decay(){

        yield return new WaitForSeconds(1);
        energy -= 2;
        hygene -= 1;        
        hunger -= 0.5f;
        thirst -= 0.5f;
        StartCoroutine(Decay());
    }
}
