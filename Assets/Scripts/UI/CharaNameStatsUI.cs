/*
 * Roswell James Castaneda
 * RED ID: 820249749
 * CS 583 Project 1
 * FileName: charaNameStatsUI.cs
 * 
 * Script that contains the functions for the input fields
 * of the Character Name and Status panels.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaNameStatsUI : MonoBehaviour
{
    private InputField nameField;
    private InputField expField;
    private InputField hpField;
    private InputField armClassField;
    private InputField speedField;
    private Player player;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        nameField = GameObject.Find("Character_Name_Input_Field").GetComponent<InputField>();
        expField = GameObject.Find("XP_InputField").GetComponent<InputField>();
        hpField = GameObject.Find("HP_InputField").GetComponent<InputField>();
        armClassField = GameObject.Find("Armor_InputField").GetComponent<InputField>();
        speedField = GameObject.Find("Speed_InputField").GetComponent<InputField>();
    }

    //Functions for Input fields
    public void editNameField()
    {
        player.charaName = nameField.text;
    }

    public void editExpField()
    {
        player.experience = int.Parse(expField.text);
    }

    public void editHpField()
    {
        player.health = int.Parse(hpField.text);
    }

    public void editArmClassField()
    {
        player.armorClass = int.Parse(armClassField.text);
    }

    public void editSpeedField()
    {
        player.speed = int.Parse(speedField.text);
    }

}