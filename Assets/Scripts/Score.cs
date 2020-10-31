using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float scoreVal;

    [SerializeField]
    private float m_ScorePerSec;

    Text score;

    private void Start()
    {
        score = GetComponent<Text>();
        scoreVal = 1f;
        m_ScorePerSec = 10f;
    }

    private void Update()
    {

        score.text = " : " + (int)scoreVal;
        scoreVal += m_ScorePerSec * Time.deltaTime;
    }
}
   

