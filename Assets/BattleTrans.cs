using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleTrans : MonoBehaviour {

	public Material transMat;
	private float cutoff;
	public string target;
	// Use this for initialization
	void Start () {
		cutoff = transMat.GetFloat ("_Cutoff");
		print (cutoff);
	}
	
	// Update is called once per frame
	void Update () {
		print (cutoff);
	}


	void OnTriggerEnter (Collider other)
	{
		
		Debug.Log ("This just happened");
		if (other.gameObject.tag == target) {
			StartCoroutine (Transition ());
			SceneManager.LoadScene ("BattleTest");
		}
	}
	
	IEnumerator Transition ()
	{
		transMat.SetFloat ("_Cutoff", 0.5f);
	
		yield return null;
	}
}