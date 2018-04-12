using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStats : MonoBehaviour {

    public Text moneyText;
    public static float currMoney;
	
	void Update () {
        moneyText.text = "" + currMoney;
        currMoney = Mathf.Round (currMoney * 100f) / 100f;
    }
}
