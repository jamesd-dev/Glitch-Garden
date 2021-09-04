using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float minSpawnDelay = 1f;
    [SerializeField] private float maxSpawnDelay = 5f;

    private bool isSpawning = true;

    IEnumerator Start()
    {
        while(isSpawning)
        {
            float spawnDelay = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(spawnDelay);
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }

}
