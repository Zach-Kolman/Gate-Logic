using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOption : MonoBehaviour {

	public string Text;
	public int DestinationNodeID;

	public void DialogueOption() {}

	public DialogOption (string text, int dest)
	{
		this.Text = text;
		this.DestinationNodeID = dest;
	}
}
