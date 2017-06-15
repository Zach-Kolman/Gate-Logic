using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleTrans : MonoBehaviour {

	public string target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("This just happened");
		if (other.gameObject.tag == target) {
			SceneManager.LoadScene ("BattleTest");
		}
	}
}
