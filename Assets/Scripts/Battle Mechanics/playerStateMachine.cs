using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStateMachine : MonoBehaviour {

	public PlayerBase player;

	public enum TurnState
	{
		PROCESSING,

		ADDTOLIST,

		WAITING,

		SELECTING,

		ACTION,

		DEAD
	}

	public TurnState curState;

	// Use this for initialization
	void Start () 
	{
		
	}
		
	// Update is called once per frame
	void Update () 
	{
		switch (curState) 
		{
		case(TurnState.PROCESSING):

			break;

		case(TurnState.ADDTOLIST):

			break;

		case(TurnState.WAITING):

			break;

		case(TurnState.SELECTING):

			break;

		case(TurnState.ACTION):

			break;

		case(TurnState.DEAD):

			break;
		}
	}
}
