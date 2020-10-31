using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefabBullet;

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



    }
    void Update()
    {

        ShootPlayer();

        foreach (Collider2D collision in Physics2D.OverlapCircleAll(transform.position, 0.02f, mask))
        {

            if (collision.CompareTag("Bullet"))
            {
                collision.tag = "Untagged";

                
                Destroy(gameObject);
                Destroy(collision.gameObject);

                //SceneManager.LoadScene("EndScene");
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
            GameObject bullet2 = Instantiate(prefabBullet, shooter.position, prefabBullet.transform.rotation);
            bullet1.transform.Rotate(0, 0, -90f);
            bullet2.transform.Rotate(0, 0, 90f);


            bullet1.layer = gameObject.layer;
            bullet2.layer = gameObject.layer;


            bullet1.GetComponent<ShootMovement>().SetDir(Vector3.down);
            bullet2.GetComponent<ShootMovement>().SetDir(Vector3.down);

        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 0.02f);
    }
}
