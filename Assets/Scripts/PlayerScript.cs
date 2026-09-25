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

    void Start()
    {
        // Nothing needed here yet
    }

    void Update()
    {
        // =====================================
        // 1. AUTOMATIC FORWARD MOVEMENT
        // =====================================

        transform.Translate(
            Vector3.forward * forwardSpeed * Time.deltaTime,
            Space.World
        );


        // =====================================
        // 2. LEFT / RIGHT INPUT
        // =====================================

        float horizontalInput = 0f;

        // Move RIGHT
        if (Keyboard.current.rightArrowKey.isPressed ||
            Keyboard.current.dKey.isPressed)
        {
            horizontalInput = 1f;
        }

        // Move LEFT
        if (Keyboard.current.leftArrowKey.isPressed ||
            Keyboard.current.aKey.isPressed)
        {
            horizontalInput = -1f;
        }


        // =====================================
        // 3. HORIZONTAL MOVEMENT
        // =====================================

        transform.Translate(
            Vector3.right *
            horizontalInput *
            horizontalSpeed *
            Time.deltaTime,
            Space.World
        );


        // =====================================
        // 4. KEEP PLAYER INSIDE Ground
        // =====================================

        Vector3 playerPosition = transform.position;

        playerPosition.x = Mathf.Clamp(
            playerPosition.x,
            minX,
            maxX
        );

        transform.position = playerPosition;
    }
}