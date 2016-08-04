using UnityEngine;
using System.Collections;

public class KnifeSpawn : MonoBehaviour
{
	public GameObject knifePrefab;
	public bool isRightSpawn;

	public void Spawn ()
	{
		GameObject knifeObject = SpawnKnife();
		HandleKnife(knifeObject);
	}

	GameObject SpawnKnife ()
	{
		return (GameObject)Instantiate(
			knifePrefab,
			RandomPosition(),
			transform.rotation
		);
	}

	void HandleKnife (GameObject knifeObject)
	{
		Knife knife = knifeObject.GetComponent<Knife>();
		knife.Flip(isRightSpawn);
		knife.Fire(isRightSpawn);
	}

	Vector2 RandomPosition ()
	{
		float y = transform.localScale.y / 2;
		return new Vector2(transform.position.x, Random.Range(-y, y));
	}
}
