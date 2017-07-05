using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueFlow : MonoBehaviour {

	public GameObject flowchart;
	public GameObject player;
	public bool isTalking;
	// Use this for initialization
	void Start () {
		isTalking = false;	
	}
	
	// Update is called once per frame
	void Update () {

		if (isTalking == true) {
			player.gameObject.transform.GetChild (2).gameObject.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E)) {
				flowchart.SetActive (true);
			}
		} else {
			player.gameObject.transform.GetChild (2).gameObject.SetActive (false);
		}
			
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {

			isTalking = true;
		}
	}

	public void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {

			isTalking = false;
			flowchart.SetActive (false);
		}
	}
}
