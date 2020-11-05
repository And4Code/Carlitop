using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpawnEnemyManager spawnEnemyManager;
    public EnemyManager enemyManagerShooter;
    public EnemyManager enemyManagerAsteroid;

    public float multiplier = 1.3f;
    public float divider = 1.3f;

    public void Disable()
    {
        
        spawnEnemyManager.IsActive = false;
    }

    public void Enable()
    {
        
        spawnEnemyManager.IsActive = true;
        FindObjectOfType<SpawnEnemyManager>().Start();
       
    }

    public void Multiply()
    {
        enemyManagerShooter.speed = enemyManagerShooter.speed * multiplier;
        enemyManagerShooter.fireRate = enemyManagerShooter.fireRate / divider;
        enemyManagerAsteroid.speed = enemyManagerAsteroid.speed * multiplier;

    }

   

   
}
