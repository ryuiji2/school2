using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public int moveSpeed;
    private Rigidbody myRigidbody;
    private Camera mainCamera;
    private Vector3 moveInput;
    private Vector3 moveVelocity;


	void Start () {
        mainCamera = FindObjectOfType<Camera> ();
        myRigidbody = GetComponent<Rigidbody> ();
	}
	
	void Update () {
        Moving ();
        Lookat ();
	}

    void Moving () {
        moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0f, Input.GetAxisRaw ("Vertical"));
        moveVelocity = moveInput * moveSpeed;
        myRigidbody.velocity = moveVelocity;
        }


    void Lookat () {
        Ray cameraRay = mainCamera.ScreenPointToRay (Input.mousePosition);
        Plane platform = new Plane (Vector3.up, Vector3.zero);
        float rayLenght;

        if (platform.Raycast (cameraRay, out rayLenght)) {
            Vector3 pointToLook = cameraRay.GetPoint (rayLenght);
            transform.LookAt (new Vector3(pointToLook.x, transform.position.y,pointToLook.z));
            }
        }
}
