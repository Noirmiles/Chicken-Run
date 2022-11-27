//Score Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    public Text scoreText;
    public Text highscoreText;
    int score = 0;
    int maxscore = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //maintain highscore during replays in session
        maxscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Eggs Collected: " + score.ToString();
        highscoreText.text = "Max Collected: " + maxscore.ToString();
    }

    void Update()
    {
        
    }
    public void AddPoint()
    {
        //adds points and updates highscore
        score += 1;
        scoreText.text = "Eggs Collected: " + score.ToString();
        if (maxscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}
