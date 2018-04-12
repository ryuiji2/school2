using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int moveSpeed;
    public int rotateSpeed;
	

	void Update () {
        Movement ();
	}
    void Movement () {
        float forwardBack = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;
        float leftRight = Input.GetAxis ("HorizontalMove") * moveSpeed * Time.deltaTime;
        float rotating = Input.GetAxis ("Horizontal") * rotateSpeed * Time.deltaTime;

        transform.Translate (leftRight, 0, forwardBack);
        transform.Rotate (0, rotating, 0);
        }
}
