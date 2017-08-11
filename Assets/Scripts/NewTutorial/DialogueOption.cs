using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOption : MonoBehaviour {

	public string Text;
	public int DestinationNodeID;


	public DialogueOption (string text, int dest)
	{
		this.Text = text;
		this.DestinationNodeID = dest;
	}
}
