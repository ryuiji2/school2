using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeScore : MonoBehaviour {

    public int red;
    public Text redText;
    public int blue;
    public Text blueText;
    public int green;
    public Text greenText;
    public int yellow;
    public Text yellowText;
    public int purple;
    public Text purpleText;
	
	void Update () {

        UIUpdate();
	}

    void UIUpdate() {
        redText.text = "Red Cubes: " + red;
        blueText.text = "Blue Cubes: " + blue;
        greenText.text = "Green Cubes " + green;
        yellowText.text = "Yellow Cubes: " + yellow;
        purpleText.text = "Purple Cubes: " + purple;
    }
}
