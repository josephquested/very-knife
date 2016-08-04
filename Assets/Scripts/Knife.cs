using UnityEngine;
using System.Collections;

public class Knife : MonoBehaviour {
	SpriteRenderer spriteRenderer;
	Rigidbody2D rb;
	public float minSpeed;
	public float maxSpeed;

	void Awake ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D>();
		Destroy(gameObject, 30);
	}

	public void Flip (bool direction)
	{
		spriteRenderer.flipX = direction;
	}

	public void Fire (bool isFiringLeft)
	{
		if (isFiringLeft)
		{
			rb.AddForce(-Vector2.right * Random.Range(minSpeed, maxSpeed));
		}
		else
		{
			rb.AddForce(Vector2.right * Random.Range(minSpeed, maxSpeed));
		}
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Knife")
		Destroy(gameObject);
  }
}
