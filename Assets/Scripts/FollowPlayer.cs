using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public float zOffset = -7f;

    private void LateUpdate()
    {
        if (playerTransform == null)
            return;

        Vector3 cameraPosition = transform.position;

        cameraPosition.z =
            playerTransform.position.z + zOffset;

        transform.position = cameraPosition;
    }
}