using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyNew : MonoBehaviour {
    
    public int buyPrice;
    public Text priceText;

    public void Update () {
        priceText.text = "Cost to unlock: " + buyPrice;
    }

    public void Unlock() {
        if(GameStats.currMoney >= buyPrice) {
            GameStats.currMoney -= buyPrice;
            Destroy (gameObject);
            }
    }
}
