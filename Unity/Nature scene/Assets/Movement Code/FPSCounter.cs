using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour {

    public Text fpsText;
    public Text canvasText;
	
	void Update () {
        canvasText.GetComponent<Text>().text = fpsText.GetComponent<Text>().text;
	}
}
