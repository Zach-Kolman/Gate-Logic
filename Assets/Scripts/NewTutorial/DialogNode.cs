using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNode : MonoBehaviour {

	public int NodeID = -1;

	public string Texty;

	public List<DialogOption> Options;

	public DialogNode () {

		Options = new List<DialogOption> ();
	}

	public DialogNode(string text)
	{
		Texty = text;
		Options = new List<DialogOption> ();
	}
}