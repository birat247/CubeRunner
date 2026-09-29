using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tapToStart;
    public GameObject scoreText;

    public void Start()
    {
        gameOverPanel.SetActive(false);
        tapToStart.SetActive(true);
        scoreText.SetActive(false);
        PauseGame();
    }

    private void Update()
    {
        // New Input System - detect left mouse click
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            StartGame();
        }
    }

    public void GameOver()
    {
        scoreText.SetActive(false);
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

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        scoreText.SetActive(true);
        tapToStart.SetActive(false);
        Time.timeScale = 1f;
    }
} 