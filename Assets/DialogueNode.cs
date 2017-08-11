using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class DialogueNode : MonoBehaviour {

	public int nodeId;
	public string text;
	public List<DialogueOption> dialogueOptionList;

	public DialogueNode(int nodeId, string text)
	{
		this.nodeId = nodeId;
		this.text = text;
	}

	public void addOption(DialogueOption choice)
	{
		dialogueOptionList.Add (choice);
	}

}
