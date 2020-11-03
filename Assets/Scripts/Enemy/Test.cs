using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UIElements;

public class Test : MonoBehaviour
{
    public EnemyManager enemyManager;



    [SerializeField]
    private Animator m_purpleAnim;

    private void Start()
    {

        m_purpleAnim.GetComponent<Animator>().Play("PurpleEnemy");


    }
    public void Update()
    {
        Move();

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
}
