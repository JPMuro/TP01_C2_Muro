using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float acceleration = 20f;
    [SerializeField] private float speed = 10;
    [SerializeField] private float friction = 5f;

    private Vector3 velocity;

    private void Update()
    {
        Vector3 forward = transform.forward * (Time.deltaTime * speed);
        Vector3 right = transform.right * (Time.deltaTime * speed);
        Vector3 up = Vector3.up * (Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += right;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position -= Vector3.up;
        }
    }

    private void OnCollisionEnter(Collision other)
    {

    }
}