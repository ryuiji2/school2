using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour {

    public GameObject pickup;
    public List<Transform> growth;
    public GameObject longerPart;
    public Transform growthLoc;
    public bool canSpawn;

	void Start () {
        growth.Add (this.transform);
        canSpawn = true;
	}
	
	void Update () {
        toSpawn ();
	}
    void toSpawn () {

        Vector3 spawnLoc = new Vector3 (Random.Range (-10, 10), 0, Random.Range (-10, 10));
        if(canSpawn == true) {
            Instantiate (pickup, spawnLoc, Quaternion.identity);
            canSpawn = false;
            }
        }
    public void OnCollisionEnter (Collision collision) {
        growthLoc = growth [growth.Count -1];
        if (collision.gameObject.tag == "pickup") {
            GameObject growthSpawn = Instantiate (longerPart, growthLoc.position - growthLoc.forward, growthLoc.rotation);
            growth.Add (growthSpawn.transform);
            canSpawn = true;
            Destroy (collision.gameObject);
            }
        if(collision.gameObject.tag == "death") {
            Destroy (this.gameObject);
            }
        }
    }
