using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : BasicItem {

public int energyVal;

	public override void OnCollisionEnter(Collision player){
		print("1");
		if(player.transform.tag == "Player"){
			GiveEnergy(energyVal);
		}
	}
	public override void GiveEnergy(int value){
		base.GiveEnergy(value);
	}
}
