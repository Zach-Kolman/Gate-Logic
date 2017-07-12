using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class dialogueFlow : MonoBehaviour {

	public int inList;
	public GameObject dialogueCanvas;
	public int listSize;
	public string charName;
//	Text charNameDisplay;
//	Text dialogueDisplay;
	public List<string> dialogueTree;
	public GameObject player;
	public bool isTalking;
	public Flowchart fungusActive;
	// Use this for initialization
	void Start () {



//		dialogueCanvas = GameObject.FindGameObjectWithTag ("DialogueCanvas");
//		dialogueCanvas.SetActive (false);
//
//		charNameDisplay = dialogueCanvas.transform.GetChild (2).GetComponent<Text> ();
//		dialogueDisplay = dialogueCanvas.transform.GetChild (3).GetComponent<Text> ();
//
//		isTalking = false;	
//		listSize = dialogueTree.Count;

	}
	
	// Update is called once per frame
	void Update () {


			
	}

	public void OnTriggerEnter(Collider other)
	{
		fungusActive.SendFungusMessage ("Activate runDialogue Starter");
		
		fungusActive.SetBooleanVariable ("isTalking", true);
	}

	public void OnTriggerExit(Collider other)
	{
		
		fungusActive.SetBooleanVariable ("isTalking", false);

	}

	IEnumerator runDialogue()
	{
		dialogueCanvas.SetActive (true);
		for (inList = 0; inList <= listSize;) {

//			charNameDisplay.text = charName.ToString ();
//			dialogueDisplay.text = dialogueTree [inList].ToString ();
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

