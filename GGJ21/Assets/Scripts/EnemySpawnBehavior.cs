using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is always running and spawns enemies to tiles
/// </summary>

public class EnemySpawnBehavior : MonoBehaviour
{
    public GameObject player;   // the player

    public GameObject enemy;    // an enemy to spawn

    // spawn x coordinates
    float xPos1;
    float xPos2;
    float xPos;

    // spawn z coordinates
    float zPos1;
    float zPos2;
    float zPos;

    int enemyCount = 0;  // number of enemies spawned
    public int enemyCountMax = 5; // number of enemies to spawn

    void Start()
    {
        //set spawn constraints
        xPos1 = gameObject.transform.position.x - 3;
        xPos2 = gameObject.transform.position.x + 3;
        zPos1 = gameObject.transform.position.y - 3;
        zPos2 = gameObject.transform.position.y + 3;
    }

    private void Update()
    {
        OnBecameVisible();
        OnBecameInvisible();
    }

    IEnumerator EnemySpawn()
    {
        while (enemyCount < enemyCountMax)
        {
            // where enemies can spawn
            xPos = Random.Range(xPos1, xPos2 + 1);
            zPos = Random.Range(zPos1, zPos2 + 1);

            // instantiate enemies
            Instantiate(enemy, new Vector3(xPos, 10, zPos), Quaternion.identity);

            // how often to spawn enemies
            yield return new WaitForSeconds(10f);

            // increment enemy count
            enemyCount++;

        }
    }

    // when the tile is seen by the camera
    private void OnBecameVisible()
    {
        // spawn enemies
        StartCoroutine(EnemySpawn());
    }

    // when the tile is not seen by the camera
    private void OnBecameInvisible()
    {
        // dont spawn enemies
        StopCoroutine(EnemySpawn());
    }
}
