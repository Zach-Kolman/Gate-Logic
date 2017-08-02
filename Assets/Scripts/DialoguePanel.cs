using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialoguePanel : MonoBehaviour {

	public Text lineText;
	public Image charPortrait;
	public Button opt1;
	public Button opt2;
	public Button opt3;
	public GameObject dialoguePanelObject;

	private static DialoguePanel dialoguePanel;

	public static DialoguePanel Instance () {
		if (!dialoguePanel) {
			dialoguePanel = FindObjectOfType (typeof(DialoguePanel)) as DialoguePanel;
			if (!dialoguePanel) {
				Debug.Log ("There needs to be one active DialoguePanel script on a GameObject in your scene.");
			}
		}

		return dialoguePanel;
	}

	public void Choices (string curLine, UnityAction opt1Event, UnityAction opt2Event, UnityAction opt3Event) {

		dialoguePanelObject.SetActive (true);

		opt1.onClick.RemoveAllListeners ();
		opt1.onClick.AddListener (opt1Event);
		opt1.onClick.AddListener (closePanel);

		opt2.onClick.RemoveAllListeners ();
		opt2.onClick.AddListener (opt2Event);
		opt2.onClick.AddListener (closePanel);

		opt3.onClick.RemoveAllListeners ();
		opt3.onClick.AddListener (opt3Event);
		opt3.onClick.AddListener (closePanel);

		this.lineText.text = lineText.ToString();

		this.charPortrait.gameObject.SetActive (false);
		opt1.gameObject.SetActive (true);
		opt2.gameObject.SetActive (true);
		opt3.gameObject.SetActive (true);
	}

	void closePanel ()
	{
		dialoguePanelObject.SetActive (false);
	}
}