using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    
    public int moveSpeed;
    public int rotateSpeed;
    public Camera mainCamera;
    public GameObject cameraLoc;
    private float mouseVer;
    private float mouseHor;
    private float sensitivity = 0.1f;
    private bool canJump = true;
    private int jumpHeight = 300;

    void Start () {

	}
	

	void Update () {
        CharMove ();
        CameraMove ();
	}

    void CharMove () {

        float forwardBack = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;
        float leftRight = Input.GetAxis ("HorizontalMove") * moveSpeed * Time.deltaTime;
        float rotating = Input.GetAxis ("Horizontal") * rotateSpeed * Time.deltaTime;

        transform.Translate (leftRight, 0, forwardBack);
        transform.Rotate (0, rotating, 0);

        if(Input.GetButtonDown ("Vertical") || Input.GetButtonDown ("Horizontal"))
        {
            mainCamera.transform.position = cameraLoc.transform.position;
            mainCamera.transform.LookAt (transform);
        }

        if (Input.GetButtonDown ("Jump") && canJump) {
            print ("jumping");
            GetComponent<Rigidbody> ().AddForce (0, jumpHeight, 0);
            canJump = false;
        }
    }
    private void OnCollisionEnter (Collision collision)
    {
       if(collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }
    void CameraMove () {

        if (Input.GetMouseButton (2))
        {
            mouseVer += Input.GetAxis ("Mouse Y") * sensitivity;
            mouseHor += -Input.GetAxis ("Mouse X") * sensitivity;
            mainCamera.transform.Translate (Vector3.up * mouseVer);
            mainCamera.transform.Translate (Vector3.right * mouseHor);
            mainCamera.transform.LookAt (transform);
        }
        mouseHor = 0;
        mouseVer = 0;
    }
}
