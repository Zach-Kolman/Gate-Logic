using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{

	public float maxSpeed = 10f;

	private Vector3 rigi;

	private bool facingRight = true;

	Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
		rigi = transform.localScale;
	}

	void Update ()
	{

		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		if (Input.GetAxis ("Horizontal") != 0 && Input.GetAxis ("Vertical") == 0) {
			anim.SetFloat ("Speed", 10);

		}
		else if (Input.GetAxis ("Horizontal") == 0 && Input.GetAxis ("Vertical") != 0) {
			anim.SetFloat ("Speed", 10);

		}
		if (Input.GetAxis ("Horizontal") != 0 && Input.GetAxis ("Vertical") != 0) {
			anim.SetFloat ("Speed", 10);

		}
		else if (Input.GetAxis ("Horizontal") == 0 && Input.GetAxis ("Vertical") == 0) {
			anim.SetFloat ("Speed", 0);
		}

	

		if (moveH > 0 && !facingRight)
			Flip ();
		else if (moveH < 0 && facingRight)
			Flip ();
	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}