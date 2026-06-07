using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;

    float spawnRate = 2f;

    float minX = -8f;
    float maxX = 8f;

    float spawnY =8f;

    void Start()
    {
        InvokeRepeating("SpawnMeteor", 2f, spawnRate);
    }

    void SpawnMeteor()
    {
        Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), spawnY, 0f);

        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);
    }
}