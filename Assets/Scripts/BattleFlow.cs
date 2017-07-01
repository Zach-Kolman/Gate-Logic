using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleFlow : MonoBehaviour {

	Animator playerAnim;
	Animator enemyAnim;

	public GameObject player;
	public GameObject enemy;
	public GameObject rangedButton;
	public GameObject directButton;
	public GameObject atkOptButton;

	public bool playerDone;

	public AudioSource battleBGM;


	// Use this for initialization
	void Start () {	

		playerDone = false;
		enemyAnim = enemy.GetComponent<Animator> ();
		playerAnim = player.GetComponent<Animator> ();
		battleBGM.time = 25.5f;
		battleBGM.Play ();
		rangedButton.SetActive (false);
		directButton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (playerDone == true) {
			StartCoroutine ("setEnemyAtkTrue");
			Debug.Log ("Ravage them");
		} 
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

	IEnumerator setPlayerAtkTrue()
	{
		playerAnim.SetBool ("Attack", true);
		yield return new WaitForSeconds (4);
		playerAnim.SetBool ("Attack", false);
		playerDone = true;
		yield return null;
	}

	IEnumerator setEnemyAtkTrue()
	{
		enemyAnim.SetBool ("playerIsDone", true);
		yield return new WaitForSeconds (3.167f);
		enemyAnim.SetBool ("playerIsDone", false);
		playerDone = false;
		StartCoroutine ("playerButtonEnable");
		yield return null;

	}


	public void runPlayerDirAttack()
	{
		if (playerAnim.GetBool ("Attack") == false) 
		{
			StartCoroutine ("setPlayerAtkTrue");
			Debug.Log ("Ravage them");
			StartCoroutine ("playerButtonDisable");
		}

	}

	IEnumerator playerButtonDisable()
	{
		rangedButton.SetActive (false);
		directButton.SetActive (false);
		atkOptButton.SetActive (false);
		yield return null;
	}

	IEnumerator playerButtonEnable()
	{
		atkOptButton.SetActive (true);
		yield return null;
	}

}

//First click button
//then show options for that choice
//when button is clicked, attack sequence is activated
//begin enemy attack when player finishes
//check all players health
//continue to next round
