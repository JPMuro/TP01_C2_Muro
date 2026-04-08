using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float acceleration = 20f;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float friction = 5f;

    private Vector3 velocity;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 input = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) input += transform.forward;
        if (Input.GetKey(KeyCode.S)) input -= transform.forward;
        if (Input.GetKey(KeyCode.D)) input += transform.right;
        if (Input.GetKey(KeyCode.A)) input -= transform.right;
        if (Input.GetKey(KeyCode.Space)) input += Vector3.up;
        if (Input.GetKey(KeyCode.LeftControl)) input -= Vector3.up;

        if (input != Vector3.zero)
            input = input.normalized;

        velocity += input * acceleration * Time.deltaTime;
        velocity = Vector3.ClampMagnitude(velocity, speed);

        if (input == Vector3.zero)
        {
            velocity = Vector3.Lerp(velocity, Vector3.zero, friction * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}