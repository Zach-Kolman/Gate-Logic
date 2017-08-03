using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour {

	public List<string> Lines;
	public List<string> QTime;
	public bool stopTime;
	public bool contTime;

	void Start(){

		stopTime = false;
		contTime = true;
	}

	void Update(){


	}
}