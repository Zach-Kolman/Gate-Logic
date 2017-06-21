using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFlow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void attackOptions(){
		Instantiate(GameObject.Find("AttackButton"));
	}
}

//First click button
//then show options for that choice
//when button is clicked, attack sequence is activated
//begin enemy attack when player finishes
//check all players health
//continue to next round
