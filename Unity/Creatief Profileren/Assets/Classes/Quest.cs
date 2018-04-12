using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour {

    public GameObject playerUI;
    public GameObject questCanvas;
    public GameObject talkCanvas;
    public int Killed;
    public bool questComplete = false;
    public List<string> questInformation;
    public List<string> questUIInformation;
    public List<int> killQuest;
    public GameObject finishedButton;
    public GameObject questButtons;

    
	void Start () {

	}
	
	void Update () {
        if (Input.GetButtonDown ("KillTest")) {
            Killed++;
        }

        QuestUpdates ();
	}
    private void OnTriggerStay (Collider trigger){

        if (trigger.transform.tag == "NPC"){
            if (Input.GetButtonDown ("Talk")){
                questCanvas.SetActive (true);
                talkCanvas.SetActive (false);
            }
        }
    }
    void QuestUpdates (){
        Text questText = questCanvas.GetComponentInChildren<Text> ();

        if (questComplete == false){
            questText.text = questInformation [0];
        }
        if(questComplete == true){
            questText.text = questInformation [1];
        }
        if(Killed == killQuest[0]) {
            questComplete = true;
            Killed = 0;
            finishedButton.SetActive (true);
            questButtons.SetActive (false);
        }
    }
    public void Accepted () {
        questCanvas.SetActive (false);
        playerUI.GetComponentInChildren<Text>().text = questUIInformation[0] + Killed + " / " + killQuest[0];
    }
    public void Declined () {
        questCanvas.SetActive (false);
    }
    public void Finished () {
        playerUI.SetActive (false);
        questUIInformation.Remove (questUIInformation [0]);
        killQuest.Remove (killQuest [0]);
        finishedButton.SetActive (false);
        questButtons.SetActive (true);
    }
}
