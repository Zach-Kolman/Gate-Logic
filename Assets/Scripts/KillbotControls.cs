using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillbotControls : MonoBehaviour {

	public Text botHP;
	public bool isHit;
	public int botHealth = 5;
	public int curHealth;
	// Use this for initialization
	void Start () {

		curHealth = botHealth;
		isHit = false;
		botHP.text = curHealth.ToString ();		
	}
	
	// Update is called once per frame
	void Update () {

		if (isHit == true) 
		{
			curHealth -= 1;
			isHit = false; 
		}

		setBotHP ();
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log ("Nothing to see here");
			isHit = true;
		}
	}

	void setBotHP()
	{
		botHP.text = curHealth.ToString ();
	}
}
