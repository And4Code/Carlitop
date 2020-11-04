using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponentEnemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    Animator anim;
   

    void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
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
        anim.SetTrigger("Dead");
        Destroy(gameObject, 3f);
    }
}
