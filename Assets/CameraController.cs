using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // El jugador
    public Vector3 offset = new Vector3(0, 3, -6);

    public float mouseSensitivity = 200f;

    float rotX = 0f;
    float rotY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        // Movimiento del mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotY += mouseX;
        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, -40f, 80f);

        // Rotación
        Quaternion rotation = Quaternion.Euler(rotX, rotY, 0);

        // Posición de la cámara
        transform.position = target.position + rotation * offset;

        // Mirar al jugador
        transform.LookAt(target.position);
    }
}