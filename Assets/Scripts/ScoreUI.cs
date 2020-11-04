using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    private void Awake()
    {
        if (!scoreText) { scoreText = GetComponent<Text>(); }
    }
    private void Update()
    {
        scoreText.text = "Score: " + Mathf.FloorToInt(Score.Instance.scoreValue);
    }
}
