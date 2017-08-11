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
	public int startLine;
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
		DialogueNode dialogueNode = dialogueManager.getDialogueNode (startLine);
		DialogueOption opt1 = dialogueNode.dialogueOptionList [0];
		DialogueOption opt2 = dialogueNode.dialogueOptionList [1];
		DialogueOption opt3 = dialogueNode.dialogueOptionList [2];

		dialogueCanvas.SetActive (true);
		while(dialogueNode.nodeId != -1)
		{

			charNameDisplay.text = charName.ToString ();

			if (Input.GetKeyDown (KeyCode.E) && dialogueNode.dialogueOptionList.Count == 0) {
				

				gameObject.transform.GetChild (0).transform.GetChild (3).GetComponent<Text> ().text = dialogueNode.text;


			} else {
				gameObject.transform.GetChild (0).transform.GetChild (4).transform.GetChild(0).GetComponent<Text>().text = opt1.Text;
			}
					
			yield return null;
		}

	}

}
