using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueFlow : MonoBehaviour {

	public int inList;
	public GameObject[] dialogueCanvases;
	public GameObject dialogueCanvas;
	public int listSize;
	public string charName;
	Text charNameDisplay;
	Text dialogueDisplay;
	public List<string> dialogueTree;
	public GameObject player;
	public int isTalking;
	public GameObject speakBubble;
	// Use this for initialization
	void Start () {

		dialogueCanvases = GameObject.FindGameObjectsWithTag ("DialogueCanvas");	


		foreach (GameObject item in dialogueCanvases) {

			charNameDisplay = item.transform.GetChild (2).GetComponent<Text> ();
			dialogueDisplay = item.transform.GetChild (3).GetComponent<Text> ();

			isTalking = 0;	
			listSize = dialogueTree.Count;

		}

	}

	// Update is called once per frame
	void Update () {

	}



	IEnumerator runDialogue()
	{
			new WaitForSeconds (0.1f);
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

	IEnumerator ChatBubbleAppear()
	{
		if (isTalking == 1) {
			speakBubble.GetComponent<MeshRenderer> ().enabled = true;
			if (Input.GetKeyDown ("e")) {
				StartCoroutine ("runDialogue");
			}
		}
		yield return null;
	}

	IEnumerator ChatBubbleDisable()
	{
		if (isTalking == 0) {
			speakBubble.GetComponent<MeshRenderer> ().enabled = false;
		}

		yield return null;
	}
		
}

