/*
 * Roswell James Castaneda
 * RED ID: 820249749
 * CS 583 Project 1
 * FileName: MainMenuUI.cs
 * 
 * Script that handles all functions
 * within the MainMenu.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class MainMenuUI : MonoBehaviour
{
    private Player player;
    private Button startButton;
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        startButton = GameObject.Find("Start_Button").GetComponent<Button>();
        //If the Player has created a character, unlock start button.
        if (player.startUnlocked == true)
        {
            startButton.interactable = true;
        }
    }
    public void rollCharacter()
    {
        SceneManager.LoadScene(1);
    }

    public void startGame()
    {

        SceneManager.LoadScene(2);
    }

    public void exitGame()
    {
        Debug.Log("Game has Quit!");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
