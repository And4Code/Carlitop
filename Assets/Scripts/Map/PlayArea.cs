using UnityEngine;

public class PlayArea : MonoBehaviour
{
    [SerializeField]

    private Camera m_Camera;

    [SerializeField]

     private float m_OffsetLimitZone = 1;

    [SerializeField]

     private float m_OffsetLimitZone2 = 9.5f;

    [SerializeField]
    
     private float m_OffsetLimitZone3 = 10f;

    private void Update()
    {
        if (transform.position.x < - m_Camera.orthographicSize * 16 / 9 + m_OffsetLimitZone)
        {
            transform.position = new Vector3(- m_Camera.orthographicSize * 16 / 9 + m_OffsetLimitZone, transform.position.y, transform.position.z);
        }

        if (transform.position.x > m_Camera.orthographicSize * 16 / 9 - m_OffsetLimitZone)
        {
            transform.position = new Vector3(m_Camera.orthographicSize * 16 / 9 - m_OffsetLimitZone, transform.position.y, transform.position.z);
        }

        if (transform.position.y < -m_Camera.orthographicSize * 16 / 9 + m_OffsetLimitZone3)
        {
            transform.position = new Vector3(transform.position.x, - m_Camera.orthographicSize * 16 / 9 + m_OffsetLimitZone3, transform.position.z);
        }

        if (transform.position.y > m_Camera.orthographicSize * 16 / 9 - m_OffsetLimitZone2)
        {
            transform.position = new Vector3(transform.position.x, m_Camera.orthographicSize * 16 / 9 - m_OffsetLimitZone2, transform.position.z);
        }

    }
}
