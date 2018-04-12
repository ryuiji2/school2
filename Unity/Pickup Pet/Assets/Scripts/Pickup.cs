using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    void Update() {
        CheckPickup();
    }
    public void CheckPickup() {
        foreach(Drop drop in FindObjectsOfType<Drop>()) {
            if(drop.canPickup == true) {
                drop.tag = "pickup";
            } else {
                drop.tag = "noPickup";
            }
        }
    }
}
