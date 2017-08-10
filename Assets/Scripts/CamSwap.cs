using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwap : MonoBehaviour {

	public GameObject[] cameras;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SelectCamera (int index) {
		for (int i = 0; i < cameras.Length; i++) {
			// Activate the selected camera
			if (i == index) {
				cameras [i].SetActive (true);
				// Deactivate all other cameras
			} else {
				cameras [i].SetActive (false);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Cam1Coll") {
			SelectCamera (0);
		}

		if (other.gameObject.tag == "Cam2Coll") {
			SelectCamera (1);
		}
	}
}


	
