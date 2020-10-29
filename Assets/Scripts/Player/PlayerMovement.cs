
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;

    [SerializeField]
    private Transform m_PlayerTransform;

    private void Start()
    {
        m_PlayerTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        Vector3 movementX = Vector3.right * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        Vector3 movementY = Vector3.up * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        transform.Translate(movementX);
        transform.Translate(movementY);
    }

}
