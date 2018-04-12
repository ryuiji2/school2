using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public GameObject cam;
    private float mouseHor = -140;
    private float mouseVer;
    public float moveSpeed;

    void Start () {
    }
    void Update () {
        Cursor.visible = false;
        MouseRot();
        Movement();
	}

    void MouseRot() {
        mouseVer += -Input.GetAxis ("Mouse Y");
        mouseHor += Input.GetAxis ("Mouse X");
        transform.eulerAngles = new Vector3 (0, mouseHor, 0);
        cam.transform.eulerAngles = new Vector3(mouseVer, mouseHor, 0);

        }

    void Movement() {
        float forwardBack = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float leftRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(leftRight, 0, forwardBack);
    }
}
