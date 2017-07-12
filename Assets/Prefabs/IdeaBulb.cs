using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdeaBulb : MonoBehaviour {

	public GameObject speakBubble;
	public GameObject[] talkies;
	// Use this for initialization
	void Start () {

		talkies = GameObject.FindGameObjectsWithTag ("Talkers");
		speakBubble = gameObject.transform.GetChild (2).gameObject;
		speakBubble.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
			if (other.gameObject.tag == "Talkers") {
				speakBubble.SetActive (true);
			}

	}

	void OnTriggerExit()
	{
		speakBubble.SetActive (false);
	}
}
