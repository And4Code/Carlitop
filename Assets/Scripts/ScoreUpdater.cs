using UnityEngine;
public class ScoreUpdater : MonoBehaviour
{
    public float scorePerSecond = 5f;
    private void Update()
    {
        Score.Instance.scoreValue += scorePerSecond * Time.deltaTime;
    }
}