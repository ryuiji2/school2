using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetAction : MonoBehaviour {

    public GameObject followPoint;
    public GameObject canPickup;
    public GameObject cubeScore;
    public float speed;


    void Update() {
        Movement();
    }

    void Movement() {
        float fast = speed * Time.deltaTime;
        if (canPickup == null) {
            transform.LookAt(followPoint.transform);
            transform.position = Vector3.MoveTowards(transform.position, followPoint.transform.position, fast);
        } else {
            transform.LookAt(canPickup.transform);
            transform.position = Vector3.MoveTowards(transform.position, canPickup.transform.position, fast);
        }
    }

    void OnTriggerStay(Collider currDrop) {
        if (canPickup == null) {
            if (currDrop.gameObject.tag == "pickup") {
                canPickup = currDrop.gameObject;
            }
        }
    }
    void OnCollisionEnter(Collision currDrop) {
        Drop drop = currDrop.gameObject.GetComponent<Drop>();
        CubeScore score = cubeScore.GetComponent<CubeScore>();

        if (currDrop.gameObject.tag == "pickup") {
            if (drop.colour == "Red") {
                score.red++;
            }
            if (drop.colour == "Blue") {
                score.blue++;
            }
            if (drop.colour == "Green") {
                score.green++;
            }
            if (drop.colour == "Yellow") {
                score.yellow++;
            }
            if (drop.colour == "Purple") {
                score.purple++;
            }
            Destroy(currDrop.gameObject);
        }
    }
}
