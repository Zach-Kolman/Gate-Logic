using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class DialogueNode : MonoBehaviour {

	public int nodeId;
	public string text;
	public int destID;
	// public List<DialogueOption> dialogueOptionList

	public DialogueNode(int nodeId, string text, int destID)
	{
		this.nodeId = nodeId;
		this.text = text;
		this.destID = destID;
	}


}
