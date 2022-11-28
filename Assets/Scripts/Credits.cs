//Credit Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    //function for quit button
    public void quitGame()
    {
        //resets highscore on Application quit
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
    //function for retry button
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
