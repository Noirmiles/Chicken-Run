﻿//Game Lost Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLost : MonoBehaviour
{
    public void LoadLoseScreen()
    {
        //loads lose scene when the game is finished
        Cursor.visible = true;
        SceneManager.LoadScene("LoseScreen");
        
    }
}