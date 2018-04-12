using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Transform playerTrans;

	void Start () {
        StartCoroutine (Moving ());
        }
	
	void Update () {

        Rotation();
	}
    void Rotation () {

        if (Input.GetButtonDown ("w")) {
            transform.eulerAngles = new Vector3 (0, 0, 0);
            playerTrans = this.transform;
        }
        if (Input.GetButtonDown ("a")) {
            transform.eulerAngles = new Vector3 (0, -90, 0);
            playerTrans = this.transform;
            }
        if (Input.GetButtonDown ("d")) {
            transform.eulerAngles = new Vector3 (0, 90, 0);
            playerTrans = this.transform;
            }
        if (Input.GetButtonDown ("s")) {
            transform.eulerAngles = new Vector3 (0, -180, 0);
            playerTrans = this.transform;
            }
    }

    IEnumerator Moving() {
        while (true) {
            transform.position += transform.forward;
            yield return new WaitForSeconds (0.3f);
            }
        }
}
