using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleFlow : MonoBehaviour {

	Animator playerAnim;
	Animator enemyAnim;

	public Material transMat;

	float cutoff;

	public GameObject player;
	public GameObject enemy;
	public GameObject enemyControls;
	public GameObject rangedButton;
	public GameObject directButton;
	public GameObject atkOptButton;
	public GameObject cam;

	public Animator camAnim;

	public bool playerDone;

	public AudioSource battleBGM;


	// Use this for initialization
	void Start () {	

		cutoff = transMat.GetFloat ("_Cutoff");

		camAnim = cam.GetComponent<Animator> ();

		playerDone = false;
		enemyAnim = enemy.GetComponent<Animator> ();
		playerAnim = player.GetComponent<Animator> ();
		battleBGM.time = 25.5f;
		battleBGM.Play ();
		rangedButton.SetActive (false);
		directButton.SetActive (false);
		StartCoroutine ("Transition");
	}
	
	// Update is called once per frame
	void Update () {

		if (playerDone == true) 
		{
			StartCoroutine ("setEnemyAtkTrue");
			Debug.Log ("Ravage them");
		} 

		if (enemyControls.GetComponent<KillbotControls> ().curHealth == 0)
		{
			StartCoroutine ("playerButtonDisable");
			enemyControls.SetActive (false);
			StartCoroutine ("finishBattle");
		}
			
		transMat.SetFloat ("_Cutoff", cutoff);
	}

	public void atkOpt()
	{
		Debug.Log ("Next option");
		atkOptButton.SetActive (false);
		rangedButton.SetActive (true);
		directButton.SetActive (true);
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
		if (enemy.activeInHierarchy == true) {
			playerDone = true;
			yield return null;
		}
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

	IEnumerator finishBattle()
	{

		StartCoroutine ("playerButtonDisable");
		yield return new WaitForSeconds (2);
		camAnim.SetBool ("Success", true);
		yield return new WaitForSeconds (3);
		StartCoroutine ("WinTrans");
		yield return null;
	}
		
	IEnumerator WinTrans()
	{
		while (cutoff < 1) {
			cutoff += 0.01f * Time.deltaTime;
			yield return null;
		}
	}


	IEnumerator Transition ()
	{
		while (cutoff > 0) {
			cutoff -= 0.5f * Time.deltaTime;
			yield return null;
		}

	}
}


//First click button
//then show options for that choice
//when button is clicked, attack sequence is activated
//begin enemy attack when player finishes
//check all players health
//continue to next round
