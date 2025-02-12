using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 2.0f; // Adjust speed

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical"); // W/S or Up/Down

        // Rotate around Y-axis (left/right movement)
        transform.Rotate(Vector3.up * horizontal * rotationSpeed, Space.World);

        // Rotate around X-axis (up/down movement)
        transform.Rotate(Vector3.right * -vertical * rotationSpeed, Space.Self);
    }
}
