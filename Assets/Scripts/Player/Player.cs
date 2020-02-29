/*
 * Roswell James Castaneda
 * RED ID: 820249749
 * CS 583 Project 1
 * FileName: Player.cs
 * 
 * Script that contains all the data of player.
 * 
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player : MonoBehaviour
{
    public bool startUnlocked;
    public bool raceModExist;
    public string charaName;
    public string race;
    public string _class;
    public string alignment;
    public int experience;
    public int health;
    public int armorClass;
    public int speed;
    public List<string> items;
    public float abilityStrength;
    public float abilityDexterity;
    public float abilityConstitution;
    public float abilityIntelligence;
    public float abilityWisdom;
    public float abilityCharisma;
    

}
