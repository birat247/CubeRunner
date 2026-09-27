using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;

    int myScore = 0;

    void Update()
    {
        scoreText.text = myScore.ToString();
    }

    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}