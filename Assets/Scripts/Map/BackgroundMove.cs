﻿
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField]
    public float speed;

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;


       
    }
}
