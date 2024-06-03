using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        GameObject ScoreUI = GameObject.Find("ScoreUI");
        scoreText = ScoreUI.GetComponent<Text>();
        scoreText.text = "0";
    }
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z; 

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
    void OnCollisionEnter(Collision coll) {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple") {
            Destroy(collidedWith);
        }

        int score = int.Parse(scoreText.text);
        score += 100;
        scoreText.text = score.ToString();

        if (score > HighScore.highScore) {
            HighScore.highScore = score;
        }
    }
}
