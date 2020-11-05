using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyRusher : MonoBehaviour
{
    public EnemyManager enemyManager;

    Vector2 playerPosStart;

    public GameObject player;

    [SerializeField]
    private Animator m_purpleAnim;


  
    private void Start()
    {
       
        m_purpleAnim.GetComponent<Animator>().Play("PurpleEnemy");
       
        
        playerPosStart = player.transform.position;
        playerPosStart = FindObjectOfType<PlayerMovement>().gameObject.transform.position;
    }
    public void Update()
    {
        
        Move();
        
    }
    public void Move()
    {

        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, player.transform.position, Time.deltaTime * enemyManager.speed);

        //Vector2 position = transform.position;

        //position = new Vector2(position.x, position.y - enemyManager.speed * Time.deltaTime);

        //transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0.1f));

        if (transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
    }
}
