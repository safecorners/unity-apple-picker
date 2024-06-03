using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int highScore = 0;
    
    void Awake() 
    {
        if (PlayerPrefs.HasKey("ApplePickerHighScore")) {
            highScore = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", highScore);
    }

    // Update is called once per frame
    void Update()
    {
        Text highScoreText = this.GetComponent<Text>();
        highScoreText.text = highScore.ToString();
        if (highScore > PlayerPrefs.GetInt("ApplePickerHighScore")) {
            PlayerPrefs.SetInt("ApplePickerHighScore", highScore);
        }
    }
}
