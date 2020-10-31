
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMovement : MonoBehaviour
{
    float speed = 5f;
    Transform bulletTransform;
    bool isMoving;
    


    Vector3 wantedDir;
    void Start()
    {
        bulletTransform = GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving) Shoot(wantedDir);


        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if (transform.position.y < min.y || transform.position.y > max.y)
        {
            Destroy(gameObject);
        }

        

    }
    public void Shoot(Vector3 shootDirection)
    {

        transform.Translate(shootDirection * Time.deltaTime * speed);

    }

    public void SetDir(Vector3 shootDir)
    {
        isMoving = true;
        wantedDir = shootDir;
    }
}
