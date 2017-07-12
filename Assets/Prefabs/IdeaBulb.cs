using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdeaBulb : MonoBehaviour {

	public GameObject[] dialogueCanvases;
	public GameObject speakBubble;
	public GameObject[] talkies;
	public int listSize;
	public List<string> dialogueTree;
	public GameObject NPC;


	// Use this for initialization
	void Start () {

		dialogueCanvases = GameObject.FindGameObjectsWithTag ("DialogueCanvas");

		talkies = GameObject.FindGameObjectsWithTag ("Talkers");

		speakBubble = gameObject.transform.GetChild (2).gameObject;
		speakBubble.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (speakBubble.activeInHierarchy == true) {

			StartCoroutine ("speechActivate");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Talkers") 
		{
			NPC = other.gameObject;
			speakBubble.SetActive (true);
		
		}

	}

	void OnTriggerExit()
	{
		speakBubble.SetActive (false);
	}

	IEnumerator speechActivate()
	{
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			NPC.GetComponent<DialogueBox> ().runDialogue ();
			yield return null;
		}
	}
}
