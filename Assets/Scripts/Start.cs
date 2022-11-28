//Game Start Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    //function for start button
    public void StartGame()
    {
        //highscore resets when app is started, but kept during the game session
        Cursor.visible = true;
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Level1");
    }
    //function for how to button
    public void Menu()
    {
        SceneManager.LoadScene("howTo");
    }
}
