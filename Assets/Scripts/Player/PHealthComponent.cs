using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHealthComponent : MonoBehaviour
{
   
    [SerializeField]

    private int  m_maxHealth = 100;

    [SerializeField]

    private int m_currentHealth;

    [SerializeField]

    //private HealthBar m_healthBar;

    void Awake()
    {
        m_currentHealth = m_maxHealth;
    }

    void Update()
    {
        if (m_currentHealth <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(int damage)
    {
        m_currentHealth -= damage;

        //if (gameObject.GetComponent<HealthBar>() != null)
        //{
        //    m_healthBar.SetHealth(m_currentHealth);
        //}


    }

    void Heal(int heal)
    {
        m_currentHealth = +heal;
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
