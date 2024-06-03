using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private ScoreManager scoreManager;

    private Text highScoreText;
    void Start() {
        this.scoreManager = Camera.main.GetComponent<ScoreManager>();
        highScoreText = this.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        highScoreText.text = scoreManager.GetHighScore().ToString();
    }
}
