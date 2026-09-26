using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            Destroy(other.gameObject);
        }
    }
}
