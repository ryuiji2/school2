using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Clicking : MonoBehaviour {
    
    public bool autoclick;
    public float autoTime;
    public int autoCost;
    public Text amBought;
    public Text autoText;
    public Text buttonMoney;
    public Text upgrade;
    public float priceIncr;
    public int modifier;
    public int purchased;
    public int baseUpgrade;
    public float upgradeCost;
    public float baseMoney;
    public float moneyToGet;
    private bool managerBought;

    private void Start () {
        autoText.text = " Manager: " + autoCost;
    }

    void Update() {
        RoundUp ();
        UIText ();
        if(autoclick == true) {
            StartCoroutine (Automatic (autoTime));
            autoclick = false;
        }
	}
    void RoundUp () {
        upgradeCost = Mathf.Round (upgradeCost * 100f) / 100f;
        moneyToGet = Mathf.Round (moneyToGet * 100f) / 100f;
    }

    void UIText () {
        buttonMoney.text = "" + moneyToGet;
        upgrade.text = "" + upgradeCost;
        amBought.text = "Bought: " + purchased;
    }

    void TheCoroutine () {
        StartCoroutine (Automatic (autoTime));

    }
    public void ButtonClick () {
        GameStats.currMoney += moneyToGet;

    }
    public void UpgradeClick () {
        if (GameStats.currMoney >= upgradeCost) {
            GameStats.currMoney -= upgradeCost;
            purchased++;
            upgradeCost = baseUpgrade * Mathf.Pow(priceIncr, purchased);
            moneyToGet = baseMoney * Mathf.Pow(priceIncr, purchased);
        }
    }
    public void Manager () {
        if (GameStats.currMoney >= autoCost) {
            if (managerBought == false) {
                autoclick = true;
                managerBought = true;
                autoText.text = " Bought!";
            }
        }
    }

    IEnumerator Automatic(float timeTowait) {
        yield return new WaitForSeconds (timeTowait);
        GameStats.currMoney += moneyToGet;
        TheCoroutine ();
    }
}
