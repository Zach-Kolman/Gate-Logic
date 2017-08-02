using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TestDialogueWindow : MonoBehaviour {

	private DialoguePanel dialoguePanel;

	void Awake () {
		dialoguePanel = DialoguePanel.Instance ();
	}

	void TestOpt1 () {

	}
}