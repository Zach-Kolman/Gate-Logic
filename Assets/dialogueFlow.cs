using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueFlow : MonoBehaviour {

	public int inList;
	public GameObject[] dialogueCanvases;
	public GameObject dialogueCanvas;
	public int listSize;
	public string charName;
	Text charNameDisplay;
	Text dialogueDisplay;
	public List<string> dialogueTree;
	public GameObject player;
	public int isTalking;

	// Use this for initialization
	void Start () {

		dialogueCanvases = GameObject.FindGameObjectsWithTag ("DialogueCanvas");	


		foreach (GameObject item in dialogueCanvases) {

			charNameDisplay = item.transform.GetChild (2).GetComponent<Text> ();
			dialogueDisplay = item.transform.GetChild (3).GetComponent<Text> ();

			isTalking = 0;	
			listSize = dialogueTree.Count;

		}

	}

	// Update is called once per frame
	void Update () {

	}


}

