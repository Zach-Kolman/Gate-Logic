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

		DialogOption opt;

		if (dest == null)
			opt = new DialogOption (text, -1);
		else
			opt = new DialogOption (text, dest.NodeID);

		node.Options.Add (opt);
	}
}