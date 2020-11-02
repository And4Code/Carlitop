using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speed = 3;
    public void Update()
    {
        Move();

    }
    public void Move()
    {
        Vector2 position = transform.position;

        position = new Vector2(position.x, position.y - speed * Time.deltaTime);

        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0.1f));

        if (transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
    }
}
