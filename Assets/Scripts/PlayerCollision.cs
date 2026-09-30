using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score score;
    public GameController gameController;

    public AudioSource collectSound;
    public AudioSource crashSound;

    private bool dead = false;

    private void OnTriggerEnter(Collider other)
    {
        // Collectable
        if (other.CompareTag("Collectables"))
        {
            if (collectSound != null)
                collectSound.Play();

            if (score != null)
                score.AddScore(1);

            Destroy(other.gameObject);
            return;
        }

        // Obstacle configured as Trigger
        if (other.CompareTag("Obstacles"))
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Obstacle configured as normal collider
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            Die();
        }
    }

    private void Die()
    {
        if (dead)
            return;

        dead = true;

        Debug.Log("PLAYER DIED");

        if (gameController != null)
        {
            gameController.GameOver();
        }
        else
        {
            Debug.LogError("GAME CONTROLLER IS NOT ASSIGNED!");
        }

        if (playerScript != null)
            playerScript.enabled = false;

        if (crashSound != null)
            crashSound.Play();
    }
}