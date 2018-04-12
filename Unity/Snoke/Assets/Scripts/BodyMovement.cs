using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMovement : MonoBehaviour {

    public GameObject player;
    public Transform playerLoc;
    public GameObject spawnedBody;

	void Start () {
        player = GameObject.Find ("Snok");
        playerLoc = player.transform;
        StartCoroutine (MovingBody ());
	}
	
	void Update () {
        playerLoc = player.GetComponent<Movement> ().playerTrans;
        Movements ();
	}
    void Movements () {
        if(playerLoc.position - playerLoc.forward == transform.position) {
            print ("hello");
            transform.rotation = player.GetComponent<Movement> ().playerTrans.rotation;
        }
    }
    IEnumerator MovingBody() {
        while (true) {
            yield return new WaitForSeconds (0.3f);
            transform.position += transform.forward;
            }
        }
    }
