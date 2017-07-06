using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueFlow : MonoBehaviour {

	public int inList;
	public GameObject dialogueCanvas;
	public int listSize;
	public string charName;
	Text charNameDisplay;
	Text dialogueDisplay;
	public List<string> dialogueTree;
	public GameObject player;
	public bool isTalking;
	// Use this for initialization
	void Start () {

		dialogueCanvas = GameObject.FindGameObjectWithTag ("DialogueCanvas");
		dialogueCanvas.SetActive (false);

		charNameDisplay = dialogueCanvas.transform.GetChild (2).GetComponent<Text> ();
		dialogueDisplay = dialogueCanvas.transform.GetChild (3).GetComponent<Text> ();

		isTalking = false;	
		listSize = dialogueTree.Count;

	}
	
	// Update is called once per frame
	void Update () {

		if (isTalking == true) {
			player.gameObject.transform.GetChild (2).gameObject.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E)) {

				StartCoroutine ("runDialogue");
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

			dialogueCanvas.SetActive (false);
			isTalking = false;
		
		}
	}

	IEnumerator runDialogue()
	{
		dialogueCanvas.SetActive (true);
		for (inList = 0; inList <= listSize;) {

			charNameDisplay.text = charName.ToString ();
			dialogueDisplay.text = dialogueTree [inList].ToString ();
			if (Input.GetKeyDown (KeyCode.E)) {
				inList += 1;
			}

//			if (inList > listSize) {
//				dialogueCanvas.SetActive (false);
//			}
			yield return null;
		}
	}
}

