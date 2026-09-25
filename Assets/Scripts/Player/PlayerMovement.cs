using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 8f;
    public float horizontalSpeed = 6f;
    float x = Mathf.Clamp(
    transform.position.x,
    -3.5f,
    3.5f
);

    void Update()
    {
        MoveForward();
        MoveHorizontal();
    }
}