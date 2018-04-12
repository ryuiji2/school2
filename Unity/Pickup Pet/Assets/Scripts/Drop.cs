using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

    public bool canPickup;
    public string colour;


    public void ChangePickup() {
        if (canPickup == true) {
            canPickup = false;
        } else {
            canPickup = true;
        }
    }
}
