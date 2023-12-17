using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform[] spawnPoints;
    public float spawnInterval = 2.0f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnPrefab();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnPrefab()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}