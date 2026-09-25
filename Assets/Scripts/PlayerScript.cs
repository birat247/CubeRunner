using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [Header("Movement")]
    public float forwardSpeed = 5f;
    public float horizontalSpeed = 5f;

    [Header("Ground Boundaries")]
    public float minX = -4.45f;
    public float maxX = 4.45f;

    void Update()
    {
        // Player position
        Vector3 playerPos = transform.position;

        // Automatically move forward
        playerPos.z += forwardSpeed * Time.deltaTime;

        // Left / Right input
        float horizontalInput = 0f;

        if (Keyboard.current.rightArrowKey.isPressed ||
            Keyboard.current.dKey.isPressed)
        {
            horizontalInput = 1f;
        }

        if (Keyboard.current.leftArrowKey.isPressed ||
            Keyboard.current.aKey.isPressed)
        {
            horizontalInput = -1f;
        }

        // Move left/right
        playerPos.x += horizontalInput * horizontalSpeed * Time.deltaTime;

        // Left boundary
        if (playerPos.x < minX)
        {
            playerPos.x = minX;
        }

        // Right boundary
        if (playerPos.x > maxX)
        {
            playerPos.x = maxX;
        }

        // Apply final position
        transform.position = playerPos;
    }
}