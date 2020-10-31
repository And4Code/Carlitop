using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : MonoBehaviour
{
    public EnemyManager enemyManager;
    public GameObject prefabBullet;
    public float nextfire = 0f;
    public LayerMask mask;

    public Score killScore;



    private void Awake()
    {
        killScore = FindObjectOfType<Score>();
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

                Destroy(gameObject);
                Destroy(collision.gameObject);
                killScore.scoreVal += 100;
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
