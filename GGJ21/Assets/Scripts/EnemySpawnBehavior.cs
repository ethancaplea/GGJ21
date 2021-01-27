using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehavior : MonoBehaviour
{
    
    public GameObject enemy;    // the enemy
    public int xPos;    // spawn x coordinate
    public int zPos;    // spawn z coordinate
    int enemyCount = 0;  // number of enemies spawned
    public int enemyCountMax; // number of enemies to spawn

    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while (enemyCount < enemyCountMax)
        {
            // where enemies can spawn
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 50);

            // instantiate enemies
            Instantiate(enemy, new Vector3(xPos, 2, zPos), Quaternion.identity);

            // how often to spawn enemies
            yield return new WaitForSeconds(5f);

            // increment enemy count
            enemyCount++;

        }
    }

}
