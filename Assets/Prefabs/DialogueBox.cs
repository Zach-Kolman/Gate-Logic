using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueBox : MonoBehaviour {

	public int inList;
	public GameObject dialogueCanvas;
	public int listSize;
	public string charName;
	public Text charNameDisplay;
	public Text dialogueDisplay;
	public List<string> dialogueTree;
	public int isTalking;
	// Use this for initialization
	void Start () {


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
		DialogueManager dialogueManager = DialogueManager.instance;
		DialogueNode dialogueNode = dialogueManager.getDialogueNode (0);
		dialogueCanvas.SetActive (true);
		while(dialogueNode.nodeId != -1)
		{

			charNameDisplay.text = charName.ToString ();

			if (Input.GetKeyDown (KeyCode.E)) {

				gameObject.transform.GetChild (0).transform.GetChild(3).GetComponent<Text>().text = dialogueNode.text;
				dialogueNode = dialogueManager.getDialogueNode (dialogueNode.destID);
			}
					
			yield return null;
		}

	}

}
