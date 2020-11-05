using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : MonoBehaviour
{
    public EnemyManager enemyManager;
    public HealthComponentEnemy healthComponent;

    public GameObject prefabBullet;
    public float nextfire = 0f;
    public LayerMask mask;

    public Score killScore;

    [SerializeField]
    private Animator m_MovementAnim;

    
    


    private void Awake()
    {
        killScore = FindObjectOfType<Score>();
        m_MovementAnim.GetComponent<Animator>().Play("BlueAnim");
    }
    public void Update()
    {
        if(Time.time > nextfire)
        {
            Shoot();
            nextfire = Time.time + enemyManager.fireRate;
            
        }
        Move();
        foreach (Collider2D collision in Physics2D.OverlapCircleAll(transform.position, 0.02f, mask))
        {

            if (collision.CompareTag("Bullet"))
            {
                collision.tag = "Untagged";
                gameObject.GetComponent<HealthComponentEnemy>().TakeDamage(35);
                if(healthComponent.currentHealth <= 0)
                {
                    int bonusPop = Random.Range(1, 3);
                    switch (bonusPop)
                    {
                        case 1:
                            GameObject newStaminaBonus = (GameObject)Instantiate(enemyManager.staminaBonus);
                            newStaminaBonus.transform.position = transform.position;
                            break;

                        case 2:
                            GameObject newHealthBonus = (GameObject)Instantiate(enemyManager.healthBonus);
                            newHealthBonus.transform.position = transform.position;
                            break;
                    }

                    Score.Instance.scoreValue += 100;
                    m_MovementAnim.SetTrigger("Dead");
                    Destroy(gameObject.GetComponent<ShooterEnemy>());
                    Destroy(gameObject, 0.5f);
                    //isDead = true;

                    //if (isDead == true)
                    //{
                    //    m_MovementAnim.SetBool("isdead", true);
                    //}

                    //if (isDead == false)
                    //{
                    //    m_MovementAnim.SetBool("isdead", false);
                    //}

                    //Destroy(gameObject);
                    //Debug.Log(gameObject);





                }

                Destroy(collision.gameObject);

              

                //killScore.scoreVal += 100;
            }


        }
       
    }
    
    public void Move()
    {
        Vector2 position = transform.position;

        position = new Vector2(position.x, position.y - enemyManager.speed * Time.deltaTime);

        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0.1f));

        if (transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
    }

    public void Shoot()
    {
        
    

        GameObject newBullet = Instantiate(prefabBullet, transform.position, Quaternion.identity);
        newBullet.layer = gameObject.layer;
        newBullet.GetComponent<ShootMovement>().SetDir(Vector2.down);

        
 
      

        
        
    }
}
