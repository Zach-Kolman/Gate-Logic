﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoBattleTrans : MonoBehaviour {

	public Material transMat;
	float cutoff;
	// Use this for initialization
	void Start () {
		cutoff = transMat.GetFloat ("_Cutoff");
		Debug.Log ("This just happened");
		StartCoroutine ("Transition");
		print (cutoff);
	}

	// Update is called once per frame
	void Update () {
		transMat.SetFloat ("_Cutoff", cutoff);
		//print (cutoff);
	}
		

	IEnumerator Transition ()
	{
		while (cutoff > 0) {
			cutoff -= 0.5f * Time.deltaTime;
			yield return null;
		}

	}

}