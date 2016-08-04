using UnityEngine;
using System.Collections;

public class GroundedCollider : MonoBehaviour
{
	Movement movement;

	void Start ()
	{
		movement = transform.parent.gameObject.GetComponent<Movement>();
	}

	void OnTriggerStay2D (Collider2D collider)
	{
		if (collider.gameObject.layer == LayerMask.NameToLayer("Solid"))
		{
			movement.grounded = true;
		}
	}

	void OnTriggerExit2D (Collider2D collider)
	{
		if (collider.gameObject.layer == LayerMask.NameToLayer("Solid"))
		{
			movement.grounded = false;
		}
	}

}
