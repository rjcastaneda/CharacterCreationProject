/*
 * Roswell James Castaneda
 * RED ID: 820249749
 * CS 583 Project 1
 * FileName: JSONUI.cs
 * 
 * Script that handles all functions
 * regarding JSON creation
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JSONUI : MonoBehaviour
{
    private Player player;
    private InputField jsonDisplay;
    public string playerJson;
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        jsonDisplay = GameObject.Find("JSON_Output_Field").GetComponent<InputField>();
    }

    //Functions for JSON Creation.
    private void displayJSON()
    {
        jsonDisplay.text = playerJson;

    }
    public void createJSON()
    {
        player.startUnlocked = true;
        playerJson = JsonUtility.ToJson(player, true);
        displayJSON();
    }
}
