using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardSpeed = 10f;
    public float sidewaysSpeed = 8f;

    public float maxX = 4f;
    public float minX = -4f;

    private float horizontalInput;

    private void Update()
    {
        horizontalInput = 0f;

        if (Keyboard.current == null)
            return;

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
    }

    private void FixedUpdate()
    {
        if (rb == null)
            return;

        Vector3 newPosition = rb.position;

        newPosition.z += forwardSpeed * Time.fixedDeltaTime;

        newPosition.x +=
            horizontalInput *
            sidewaysSpeed *
            Time.fixedDeltaTime;

        newPosition.x =
            Mathf.Clamp(newPosition.x, minX, maxX);

        rb.MovePosition(newPosition);
    }
}