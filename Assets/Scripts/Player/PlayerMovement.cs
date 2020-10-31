
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float m_Speed = 3f;

    [SerializeField]
    private Transform m_PlayerTransform;

    [SerializeField]
    private Animator m_MoveAnim;

    private void Start()
    {
        m_PlayerTransform = GetComponent<Transform>();
        m_MoveAnim.GetComponent<Animator>().Play("PlayerAnim");
    }

    private void Update()
    {
        Movements();
    }

   public void Movements()
    {
        Vector3 movementX = Vector3.right * Input.GetAxisRaw("Horizontal") * m_Speed * Time.deltaTime;
        Vector3 movementY = Vector3.up * Input.GetAxisRaw("Vertical") * m_Speed * Time.deltaTime;

        transform.Translate(movementX);
        transform.Translate(movementY);
    }
}
