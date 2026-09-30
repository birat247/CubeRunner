using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject tapToStart;
    public GameObject scoreText;

    private bool gameStarted = false;
    private bool gameEnded = false;

    private void Start()
    {
        Time.timeScale = 0f;

        gameOverCanvas.SetActive(false);
        tapToStart.SetActive(true);
        scoreText.SetActive(false);
    }

    private void Update()
    {
        if (!gameStarted && !gameEnded && Input.GetMouseButtonDown(0))
        {
            StartGame();
        }

        if (!gameStarted && !gameEnded && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        gameStarted = true;

        tapToStart.SetActive(false);
        scoreText.SetActive(true);

        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        if (gameEnded)
            return;

        gameEnded = true;

        Debug.Log("GAME OVER CALLED");

        // Show game over UI
        gameOverCanvas.SetActive(true);

        // Hide normal score
        scoreText.SetActive(false);

        // Stop game
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}