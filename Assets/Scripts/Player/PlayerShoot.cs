using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
    public GameObject prefabBullet;

    private PHealthComponent health;
    private ShootMovement shootMov;
    [SerializeField]
    private Transform shooter;
    public LayerMask mask;


 


   

    //angles possibles pour shoots.

    float angle = -15f;
    float angle1 = 15f;
    float angle2 = -7.5f;
    float angle3 = 7.5f;
    float angle4 = 10f;
    float angle5 = -10f;
    float angle6 = 5f;
    float angle7 = -5f;




    private void Awake()
    {
        shootMov = FindObjectOfType<ShootMovement>();
        health = GetComponent<PHealthComponent>();


    }
    void Update()
    {

        ShootPlayer();

        foreach (Collider2D collision in Physics2D.OverlapCircleAll(transform.position, 0.02f, mask))
        {

            if (collision.CompareTag("Bullet"))
            {
                collision.tag = "Untagged";


                health.TakeDamage(20);
                Destroy(collision.gameObject);

                
            }

            if (collision.CompareTag("StaminaBonus"))
            {
                collision.tag = "Untagged";
                GetComponent<StaminaComponent>().IncreaseStamina(5);
                Destroy(collision.gameObject);
            }

            if (collision.CompareTag("HealthBonus"))
            {
                collision.tag = "Untagged";
                health.Heal(5);
                Destroy(collision.gameObject);
            }

            if (collision.CompareTag("Asteroid"))
            {
                collision.tag = "Untagged";
                health.TakeDamage(20);
                Destroy(collision.gameObject);
            }


        }

    }



    





    void ShootPlayer()
    {




        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet1 = Instantiate(prefabBullet,  transform.position, prefabBullet.transform.rotation );
            bullet1.transform.Rotate(0, 0, 0f);
            bullet1.GetComponent<ShootMovement>().SetDir(Vector3.down);
            bullet1.layer = gameObject.layer;
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    GameObject go = Instantiate(tamere, Position, angle) as GameObject;
            //    goList.Add(go);
            //    go.GetComponent<ShootMovement>().SetDir(new Vector3());
            //}
            GameObject bullet1 = Instantiate(prefabBullet, shooter.position, prefabBullet.transform.rotation);
            
            bullet1.transform.Rotate(0, 0, 180f);
          


            bullet1.layer = gameObject.layer;
          


            bullet1.GetComponent<ShootMovement>().SetDir(Vector3.down);
            
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 0.02f);
    }
}
