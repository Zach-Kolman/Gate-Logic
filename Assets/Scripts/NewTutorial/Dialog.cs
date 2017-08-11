using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public class Dialog : MonoBehaviour {

	public List<DialogNode> Nodes;

	public void AddNode(DialogNode node)
	{

		if(node == null) return;

		Nodes.Add (node);

		node.NodeID = Nodes.IndexOf (node);
	}

	public void AddOption(string text, DialogNode node, DialogNode dest)
	{

		if(!Nodes.Contains(dest))
			AddNode(dest);

		if (!Nodes.Contains (node))
			AddNode (node);

		DialogueOption opt;

		if (dest == null)
			opt = new DialogueOption (text, -1);
		else
			opt = new DialogueOption (text, dest.NodeID);

		node.Options.Add (opt);
	}
}