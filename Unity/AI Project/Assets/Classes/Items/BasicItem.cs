using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicItem : MonoBehaviour {


    public float energyVal, HungerVal, HygeneVal, ThirstVal;
    
    public virtual void Start () {
        
    }

    public virtual void Increase (Collision player) {

    }
    public virtual void Decrease (Collision player) {

    }
}