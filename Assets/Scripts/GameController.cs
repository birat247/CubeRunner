using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void Start()
    {
        gameOverPanel.SetActive(false);
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);

    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}