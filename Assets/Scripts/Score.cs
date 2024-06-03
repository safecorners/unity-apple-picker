using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private ScoreManager scoreManager;

    private Text scoreText;
    void Start()
    {
        this.scoreManager = Camera.main.GetComponent<ScoreManager>();
        scoreText = this.GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = scoreManager.GetScore().ToString();
    }
}
