using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int highScore = 0;
    private int score = 0;

    void Awake()
    {
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            highScore = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", highScore);
    }

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        if (score > highScore)
        {
            highScore = score;
        }

        if (highScore > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", highScore);
        }
    }
    public int GetHighScore()
    {
        return highScore;
    }
    public int GetScore()
    {
        return score;
    }
    public void IncreaseScore()
    {
        score += 100;
    }
}
