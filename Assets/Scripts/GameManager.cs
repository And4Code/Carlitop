using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpawnEnemyManager spawnEnemyManager;

    public void Disable()
    {
        
        spawnEnemyManager.IsActive = false;
    }

    public void Enable()
    {
        
        spawnEnemyManager.IsActive = true;
        FindObjectOfType<SpawnEnemyManager>().Start();
       
    }

   

   
}
