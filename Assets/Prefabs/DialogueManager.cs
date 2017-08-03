using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;


public class DialogueManager : MonoBehaviour {


	public List<DialogueNode> DialogueNodeList;

	public static DialogueManager instance = null;
	//Current level number, expressed in game as "Day 1".

	//Awake is always called before any Start functions
	void Awake()
	{
		//Check if instance already exists
		if (instance == null)

			//if not, set instance to this
			instance = this;

		//If instance already exists and it's not this:
		else if (instance != this)

			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy(gameObject);    

		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);

		//Get a component reference to the attached BoardManager script
	
	}

	//Initializes the game for each level.
	void Start()
	{
		Debug.Log ("I got here");

		DialogueManager manager = DialogueManager.instance;
		manager.loadDialogueFile("TestDialogueRun.xml");	
	}

	//Update is called every frame.
	void Update()
	{

	}

	void loadDialogueFile(string fileName){

		string xmlString = @"<?xml version=""1.0"" encoding=""UTF-8"" ?>
<Dialogue xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""hhtp://www.w3.org/2001/XMLSchema"">
	<DialogueNode>
		<NodeID>0</NodeID>
		<Text>Hey baby.</Text>
		<Option>
			<DialogueOption>
				<Text>Do I know you?</Text>
				<DestinationNodeID>1</DestinationNodeID>
			</DialogueOption>
			<DialogueOption>
				<Text>Whats up ;)</Text>
				<DestinationNodeID>2</DestinationNodeID>
			</DialogueOption>
		</Option>
	</DialogueNode>
	<DialogueNode>
		<NodeID>1</NodeID>
		<Text>Weve only been married six years.</Text>
		<DestinationNodeID>-1</DestinationNodeID>
	</DialogueNode>
</Dialogue>";

		DialogueManager dialogueManager = DialogueManager.instance;

		using (XmlReader reader = XmlReader.Create (new StringReader (xmlString))) {
			while (reader.ReadToFollowing ("NodeID")) {
				int nodeId = reader.ReadElementContentAsInt ();

				reader.ReadToFollowing ("Text");
				string text = reader.ReadElementContentAsString ();

				reader.ReadToFollowing ("DestinationNodeID");
				int destId = reader.ReadElementContentAsInt ();

				DialogueNode dialogueNode = new DialogueNode (nodeId, text, destId);
				dialogueManager.DialogueNodeList.Add(dialogueNode);

					//dialogueNode.dialogueOptionList.add(new DialogueOption(text, destId))

			}
		}

		foreach (DialogueNode n in dialogueManager.DialogueNodeList) {

			Debug.Log ("Text: " + n.text);
			Debug.Log ("NodeId: " + n.nodeId);
			Debug.Log ("DestId: " + n.destID);

		}

	}

	public DialogueNode getDialogueNode(int nodeId)
	{
		DialogueManager dialogueManager = DialogueManager.instance;

		foreach (DialogueNode n in dialogueManager.DialogueNodeList) {

			if (n.nodeId == nodeId) {
				return n;
			}
		}

		return null;
	}

}