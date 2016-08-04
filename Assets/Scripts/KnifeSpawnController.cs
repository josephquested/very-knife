using UnityEngine;
using System.Collections;

public class KnifeSpawnController : MonoBehaviour
{
	float cooldown;
	public float delay;
	public KnifeSpawn leftKnifeSpawn;
	public KnifeSpawn rightKnifeSpawn;

	void Update ()
	{
		cooldown -= 0.1f;
		if (cooldown <= 0)
		{
			RandomSpawner().Spawn();
			cooldown = delay;
		}
	}

	KnifeSpawn RandomSpawner ()
	{
    if (Random.value >= 0.5)
    {
      return leftKnifeSpawn;
    }
    return rightKnifeSpawn;
	}
}
