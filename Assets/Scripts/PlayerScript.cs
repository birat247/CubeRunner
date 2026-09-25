using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float horizontalSpeed = 5f;

    void Update()
    {
        // Move forward automatically
        transform.Translate(
            Vector3.forward * forwardSpeed * Time.deltaTime
        );

        // Left and right movement
        float horizontal = 0f;

        if (Keyboard.current.aKey.isPressed ||
            Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1f;
        }

        if (Keyboard.current.dKey.isPressed ||
            Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1f;
        }

        transform.Translate(
            Vector3.right * horizontal * horizontalSpeed * Time.deltaTime
        );
    }
}