using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleFlow : MonoBehaviour {
	
	public AudioSource battleBGM;
	public GameObject rangedButton;
	public GameObject directButton;
	public GameObject atkOptButton;

	// Use this for initialization
	void Start () {	
		
		battleBGM.time = 25.5f;
		battleBGM.Play ();
		rangedButton.SetActive (false);
		directButton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void atkOpt()
	{
		Debug.Log ("Next option");
		rangedButton.SetActive (true);
		directButton.SetActive (true);
		atkOptButton.SetActive (false);
	}

	public void rangedOpt()
	{
		Debug.Log ("Hey baby");
	}

	public void directOpt()
	{
		Debug.Log ("Ohhh");
	}
}

//First click button
//then show options for that choice
//when button is clicked, attack sequence is activated
//begin enemy attack when player finishes
//check all players health
//continue to next round
