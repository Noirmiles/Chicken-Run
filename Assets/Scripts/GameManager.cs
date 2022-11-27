//Game Manager Script for Chicken Dash
//Programmers: Garret Lawrence, Myles Thompkins, and Joshua Velazquez
//Major Project for CS 347-02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeGameUI;
    public GameObject lostGameUI;
    public void WinGame()
    {
        //pulls up the win screen and transition to win scene
        completeGameUI.SetActive(true);
    }
    public void LostGame()
    {
        //pulls up the lose screen and transitions to the lose scene
        lostGameUI.SetActive(true);   
    }
}
