using UnityEngine;

public class LoopBackground : MonoBehaviour
{
    [SerializeField]
    private int m_NbrBackgrounds;

    [SerializeField]
    private float m_OverlapSpace;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("LOOP");
        float hBackground = ((BoxCollider2D)collision).size.y;

        Vector3 pos = collision.transform.position;
        pos.y += (hBackground * m_NbrBackgrounds) - m_OverlapSpace;

        collision.transform.position = pos;
    }
}
