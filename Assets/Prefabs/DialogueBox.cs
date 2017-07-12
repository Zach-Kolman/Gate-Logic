using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueBox : MonoBehaviour {

	public int inList;
	public GameObject dialogueCanvas;
	public int listSize;
	public string charName;
	Text charNameDisplay;
	Text dialogueDisplay;
	public List<string> dialogueTree;
	public int isTalking;
	// Use this for initialization
	void Start () {

		charNameDisplay = transform.GetChild (2).GetComponent<Text> ();
		dialogueDisplay = transform.GetChild (3).GetComponent<Text> ();

		listSize = dialogueTree.Count;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void runDialogue()
	{
		StartCoroutine ("CoRunDialogue");
	}

	private IEnumerator CoRunDialogue()
	{
		dialogueCanvas.SetActive (true);
		for (inList = 0; inList <= listSize;) {

			charNameDisplay.text = charName.ToString ();
			dialogueDisplay.text = dialogueTree [inList].ToString ();
			if (Input.GetKeyDown (KeyCode.E)) {
				inList += 1;
			}
				
			yield return null;
		}

	}

}
