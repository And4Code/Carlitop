using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PHealthComponent : MonoBehaviour
{
   
    [SerializeField]

    private int  m_maxHealth = 100;

    

    public int currentHealth;

    [SerializeField]

    private HealthBar m_healthBar;

    void Awake()
    {
        currentHealth = m_maxHealth;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (gameObject.GetComponent<HealthBar>() != null)
        {
            m_healthBar.SetHealth(currentHealth);
        }


    }

     public void Heal(int heal)
    {
        currentHealth += heal;
    }

    void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");

    }
}
