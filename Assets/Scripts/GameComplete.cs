//Game Win Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public void LoadWinScreen()
    {
        //loads win scene when the game is finished
        Cursor.visible = true;
        SceneManager.LoadScene("WinScreen");
        
    }
}
