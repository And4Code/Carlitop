using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyManager : MonoBehaviour
{
    public GameObject prefabEnemy1;
    public GameObject prefabEnemy2;
    public GameObject prefabEnemy3;

    public float spawnRate;

    void Start()
    {
        Invoke("Spawn", spawnRate);
        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    }

    void Spawn()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0.05f, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(0.95f, 1));


        int whoSpawn = Random.Range(1, 4);
        switch (whoSpawn)
        {
            case 1:
                GameObject newEnemy1 = (GameObject)Instantiate(prefabEnemy1);
                newEnemy1.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
                break;
            case 2:
                GameObject newEnemy2 = (GameObject)Instantiate(prefabEnemy2);
                newEnemy2.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
                break;
            case 3:
                GameObject newEnemy3 = (GameObject)Instantiate(prefabEnemy3);
                newEnemy3.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
                break;

            default:
                break;
        }



        NextEnnemySpawn();
    }

    void NextEnnemySpawn()
    {
        float otherSpawn;

        if (spawnRate > 1f)
        {
            otherSpawn = Random.Range(1f, spawnRate);
        }
        else
        {
            otherSpawn = 1f;
        }
        Invoke("Spawn", otherSpawn);
    }

    void IncreaseSpawnRate()
    {
        if (spawnRate > 1f)
        {
            spawnRate--;
        }
        if (spawnRate == 1)
        {
            CancelInvoke("IncreaseSpawnRate");
        }
    }
}
