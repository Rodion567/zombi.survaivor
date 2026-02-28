using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public float spawnDelay = 3f;

    void Start()
    {
        InvokeRepeating("SpawnZombie", 2f, spawnDelay);
    }

    void SpawnZombie()
    {
        Instantiate(zombiePrefab, transform.position, Quaternion.identity);
    }
}
