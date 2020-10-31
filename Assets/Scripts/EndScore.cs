using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public Score endScore;

   [SerializeField]
    private float m_EndScore;

    Text finalScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        m_EndScore = endScore.scoreVal;
        finalScore.text = "" + (int)m_EndScore;
    }
}
