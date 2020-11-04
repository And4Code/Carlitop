using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyManager : MonoBehaviour
{
    public GameObject enemyShooter;
    public GameObject enemyRusher;
    public GameObject asteroid;
    public bool IsActive = true;

    public float spawnRate;

    public void Start()
    {
        
        
            Invoke("Spawn", spawnRate);
            InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
        
        
    }

    public void Spawn()
    {
        if (IsActive)
        {
            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0.05f, 0));
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(0.95f, 1));


            int whoSpawn = Random.Range(1, 4);
            switch (whoSpawn)
            {
                case 1:
                    GameObject newEnemyShooter = (GameObject)Instantiate(enemyShooter);
                    newEnemyShooter.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
                    break;
                case 2:
                    GameObject newEnemyRusher = (GameObject)Instantiate(enemyRusher);
                    newEnemyRusher.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
                    break;
                case 3:
                    GameObject newAsteroid = (GameObject)Instantiate(asteroid);
                    newAsteroid.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
                    break;

                default:
                    break;
            }



            NextEnnemySpawn();
        }
        
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
