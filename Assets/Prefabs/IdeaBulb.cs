using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdeaBulb : MonoBehaviour {


	public GameObject speakBubble;
	public GameObject[] talkies;
	public int listSize;
	public List<string> dialogueTree;
	public GameObject NPC;
	GameObject NPCcanvas;


	// Use this for initialization
	void Start () {

		talkies = GameObject.FindGameObjectsWithTag ("Talkers");

		speakBubble = gameObject.transform.GetChild (2).gameObject;
		speakBubble.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (speakBubble.activeInHierarchy == true) {

			StartCoroutine ("speechActivate");
		}

		if (speakBubble.activeInHierarchy == false) {

			StopCoroutine ("speechActivate");
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

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Talkers") {
			NPC = other.gameObject;
			NPCcanvas = NPC.transform.GetChild (0).gameObject;
			NPCcanvas.SetActive (false);
			speakBubble.SetActive (false);
		
		}

	}

	IEnumerator speechActivate()
	{
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			NPC.GetComponent<DialogueBox> ().runDialogue ();
			yield return null;
		}
	}

	IEnumerator speechDeactivate ()
	{
		if (gameObject.transform.GetChild (2).gameObject.activeInHierarchy == false) 
		{
			Debug.Log ("fuck");
			NPCcanvas.SetActive (false);
			yield return null;
		}
	}
}
