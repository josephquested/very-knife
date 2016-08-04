using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	Rigidbody2D rb;
	bool crouching;
	public bool facingLeft;
	public bool grounded;
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate ()
	{
		ApplyGravity();
	}

	public void RecieveMovementInput (float horizontal)
	{
		UpdateDirection(horizontal);
		Vector3 movement = new Vector3(horizontal * speed, 0, 0);
		if (crouching || !grounded) movement = movement / 2;
		rb.AddForce(movement);
	}

	public void RecieveJumpInput (bool jump)
	{
		if (jump && grounded)
		{
			rb.AddForce(Vector3.up * jumpSpeed);
		}
	}

	public void RecieveCrouchInput (bool crouch)
	{
		if (crouch)
		{
			crouching = true;
			transform.localScale = new Vector3(1, 1, 1);
		}
		else
		{
			crouching = false;
			transform.localScale = new Vector3(1, 2, 1);
		}
	}

	void ApplyGravity ()
	{
		if (!grounded)
		{
			rb.AddForce(Vector3.down * gravity);
		}
	}

	void UpdateDirection (float horizontal)
	{
		if (horizontal < 0) facingLeft = true;
		if (horizontal > 0) facingLeft = false;
	}
}
