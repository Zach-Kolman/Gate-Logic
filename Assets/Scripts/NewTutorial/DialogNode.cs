using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNode : MonoBehaviour {

	public int NodeID = -1;

	public string Texty;

	public List<DialogueOption> Options;

	public DialogNode () {

		Options = new List<DialogueOption> ();
	}

	public DialogNode(string text)
	{
		Texty = text;
		Options = new List<DialogueOption> ();
	}
}