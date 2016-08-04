using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	Movement movement;

	void Start ()
	{
		movement = GetComponent<Movement>();
	}

	void FixedUpdate ()
	{
		MovementInput();
		CrouchInput();
	}

	void Update ()
	{
		JumpInput();
	}

	void MovementInput ()
	{
		movement.RecieveMovementInput(Input.GetAxis("Horizontal"));
	}

	void JumpInput ()
	{
		movement.RecieveJumpInput(Input.GetButtonDown("Jump"));
	}

	void CrouchInput ()
	{
		movement.RecieveCrouchInput(Input.GetButton("Crouch"));
	}
}
