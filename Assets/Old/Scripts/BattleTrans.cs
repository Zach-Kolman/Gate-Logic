using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleTrans : MonoBehaviour
{
	public bool isDone;
	public Material transMat;
	float cutoff;
	public string target;
	// Use this for initialization
	void Start ()
	{
		isDone = false;
		cutoff = transMat.GetFloat ("Cutoff");
		print (cutoff);
	}

	// Update is called once per frame
	void Update ()
	{
		if (cutoff >= 1) {
			isDone = true;
		}

		if (isDone == true) {
			StartCoroutine ("SceneSwap");
		}
		transMat.SetFloat ("_Cutoff", cutoff);
		print (cutoff);
	}



	void OnTriggerEnter (Collider other)
	{
		
		Debug.Log ("This just happened");
		if (other.gameObject.tag == target) {
			StartCoroutine ("Transition");

		}
	}
		
	
	IEnumerator Transition ()
	{
		while (cutoff < 1) {
			cutoff += Time.deltaTime;
			yield return null;
		}

	}

	IEnumerator SceneSwap ()
	{
		SceneManager.LoadScene ("BattleTest");
		Debug.Log ("This shit lit");
		yield return null;
	}
}