
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;

    [SerializeField]
    private Transform m_PlayerTransform;

    [SerializeField]
    private LayerMask m_PlayerMask;

    // private int m_AccelerationTime = 3;
    // public CameraShake cameraShake;
    // bool isShaking;


    private void Start()
    {
        m_PlayerTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        Movements();
    }

   public void Movements()
    {
        Vector3 movementX = Vector3.right * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        Vector3 movementY = Vector3.up * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        transform.Translate(movementX);
        transform.Translate(movementY);
    }
}
