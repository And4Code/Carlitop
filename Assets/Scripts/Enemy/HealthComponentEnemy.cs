using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponentEnemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

   

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

    }

    public void Heal()
    {

    }

    public void Die()
    {
        
        Destroy(gameObject);
    }
}
