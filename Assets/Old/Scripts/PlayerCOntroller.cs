using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{
	public float maxSpeed = 10f;

	private Vector3 rigi;

	bool isAttacking;
	private bool facingRight = true;
	//private bool facingTowards = true;
	Animator anim;

	void Start ()
	{
		anim = gameObject.GetComponent<Animator> ();
		rigi = transform.localScale;
	}

	void Update ()
	{
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		if (Input.GetAxis ("Horizontal") != 0 && Input.GetAxis ("Vertical") == 0) {
			anim.SetFloat ("Speed", 1);
			anim.SetFloat ("Backwards", 0);

		}
		if (Input.GetAxis ("Horizontal") == 0 && Input.GetAxis ("Vertical") > 0) {
			anim.SetFloat ("Backwards", 1);
			anim.SetFloat ("Speed", 0);
		}

		else if (Input.GetAxis ("Horizontal") == 0 && Input.GetAxis ("Vertical") <= 0) {
			anim.SetFloat ("Speed", 1);
			anim.SetFloat ("Backwards", 0);

		}
		if (Input.GetAxis ("Horizontal") != 0 && Input.GetAxis ("Vertical") > 0) {
			anim.SetFloat ("Backwards", 1);
			anim.SetFloat ("Speed", 0);

		}

		else if (Input.GetAxis ("Horizontal") != 0 && Input.GetAxis ("Vertical") <= 0) {
			anim.SetFloat ("Speed", 1);
			anim.SetFloat ("Backwards", 0);

		}
		else if (Input.GetAxis ("Horizontal") == 0 && Input.GetAxis ("Vertical") == 0) {
			anim.SetFloat ("Speed", 0);
			anim.SetFloat ("Backwards", 0);
		}

	

		if (moveH > 0 && !facingRight)
			Flip ();
		else if (moveH < 0 && facingRight)
			Flip ();

//		if (moveV > 0 && !facingTowards)
//			FlipBack ();
//		else if (moveV < 0 && facingTowards)
//			FlipBack ();
	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}



//	void FlipBack ()
//	{
//		facingTowards = !facingTowards;
//		Vector3 theBehind;
//		theBehind.x *= -1;
//		anim.SetFloat ("Backwards", theBehind.x);
//	}
}