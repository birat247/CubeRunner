using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public void GameOver()
    {
        gameOverPanel.SetActive(true);

    }
}