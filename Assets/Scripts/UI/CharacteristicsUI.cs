/*
 * Roswell James Castaneda
 * RED ID: 820249749
 * CS 583 Project 1
 * FileName: charaNameStatsUI.cs
 * 
 * Script that handles all functions
 * withing the Characteristics Panel.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacteristicsUI : MonoBehaviour
{
    private Player player;
    private Dropdown raceDD;
    private Dropdown classDD;
    private Dropdown alignDD;
    
    private List<string> races = new List<string>
    {
        "Dragonborn",
        "Dwarf",
        "Elf",
        "Gnome",
        "Half-Elf",
        "Half-Orc",
        "Halfling",
        "Human",
        "Tiefling"
    };
    private List<string> classes = new List<string>
    {
        "Barbarian",
        "Bard",
        "Cleric",
        "Druid",
        "Fighter",
        "Monk",
        "Paladin",
        "Ranger",
        "Rogue",
        "Sorcerer",
        "Warlock",
        "Wizard"
    };
    private List<string> alignments = new List<string>
    {
        "Lawful Good",
        "Neutral Good",
        "Chaotic Good",
        "Lawful Neutral",
        "Neutral",
        "Chaotic Neutral",
        "Lawful Evil",
        "Neutral Evil",
        "Chaotic Evil"
    };



    void Start()
    {
        //Initialize all game objects
        player = GameObject.Find("Player").GetComponent<Player>();
        raceDD = GameObject.Find("Race_Dropdown").GetComponent<Dropdown>();
        classDD = GameObject.Find("Class_Dropdown").GetComponent<Dropdown>();
        alignDD = GameObject.Find("Alignment_Dropdown").GetComponent<Dropdown>();
        raceDD.AddOptions(races);
        classDD.AddOptions(classes);
        alignDD.AddOptions(alignments);

    }

    //Modifies or demodifies the stats of player based on race.
    private void raceModifier(string playerRace, bool resetModifiers)
    {
        //Make all races modify all stats by 2 for now.
        const int RACE_MODIFIER = 2;

        if (playerRace == "Dragonborn" && resetModifiers == true  )
        {
            player.abilityStrength = player.abilityStrength - RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity - RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution - RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence - RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom - RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma - RACE_MODIFIER;
            return;
        }
        else if (playerRace == "Dragonborn" && resetModifiers == false )
        {
            player.abilityStrength = player.abilityStrength + RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity + RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution + RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence + RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom + RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma + RACE_MODIFIER;
            return;
        }

        if (playerRace == "Dwarf" && resetModifiers == true)
        {
            player.abilityStrength = player.abilityStrength - RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity - RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution - RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence - RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom - RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma - RACE_MODIFIER;
            return;
        }
        else if (playerRace == "Dwarf" && resetModifiers == false)
        {
            player.abilityStrength = player.abilityStrength + RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity + RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution + RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence + RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom + RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma + RACE_MODIFIER;
            return;
        }

        if (playerRace == "Elf" && resetModifiers == true)
        {
            player.abilityStrength = player.abilityStrength - RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity - RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution - RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence - RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom - RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma - RACE_MODIFIER;
            return;
        }
        else if (playerRace == "Elf" && resetModifiers == false)
        {
            player.abilityStrength = player.abilityStrength + RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity + RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution + RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence + RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom + RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma + RACE_MODIFIER;
            return;
        }

        if (playerRace == "Gnome" && resetModifiers == true)
        {
            player.abilityStrength = player.abilityStrength - RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity - RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution - RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence - RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom - RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma - RACE_MODIFIER;
            return;
        }
        else if (playerRace == "Gnome" && resetModifiers == false)
        {
            player.abilityStrength = player.abilityStrength + RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity + RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution + RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence + RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom + RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma + RACE_MODIFIER;
            return;
        }

        if (playerRace == "Half-Elf" && resetModifiers == true)
        {
            player.abilityStrength = player.abilityStrength - RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity - RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution - RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence - RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom - RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma - RACE_MODIFIER;
            return;
        }
        else if (playerRace == "Half-Elf" && resetModifiers == false)
        {
            player.abilityStrength = player.abilityStrength + RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity + RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution + RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence + RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom + RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma + RACE_MODIFIER;
            return;
        }

        if (playerRace == "Half-Orc" && resetModifiers == true)
        {
            player.abilityStrength = player.abilityStrength - RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity - RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution - RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence - RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom - RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma - RACE_MODIFIER;
            return;
        }
        else if (playerRace == "Half-Orc" && resetModifiers == false)
        {
            player.abilityStrength = player.abilityStrength + RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity + RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution + RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence + RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom + RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma + RACE_MODIFIER;
            return;
        }

        if (playerRace == "Halfling" && resetModifiers == true)
        {
            player.abilityStrength = player.abilityStrength - RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity - RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution - RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence - RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom - RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma - RACE_MODIFIER;
            return;
        }
        else if (playerRace == "Halfling" && resetModifiers == false)
        {
            player.abilityStrength = player.abilityStrength + RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity + RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution + RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence + RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom + RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma + RACE_MODIFIER;
            return;
        }

        if (playerRace == "Human" && resetModifiers == true)
        {
            player.abilityStrength = player.abilityStrength - RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity - RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution - RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence - RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom - RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma - RACE_MODIFIER;
            return;
        }
        else if (playerRace == "Human" && resetModifiers == false)
        {
            player.abilityStrength = player.abilityStrength + RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity + RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution + RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence + RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom + RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma + RACE_MODIFIER;
            return;
        }

        if (playerRace == "Tiefling" && resetModifiers == true)
        {
            player.abilityStrength = player.abilityStrength - RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity - RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution - RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence - RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom - RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma - RACE_MODIFIER;
            return;
        }
        else if (playerRace == "Tiefling" && resetModifiers == false)
        {
            player.abilityStrength = player.abilityStrength + RACE_MODIFIER;
            player.abilityDexterity = player.abilityDexterity + RACE_MODIFIER;
            player.abilityConstitution = player.abilityConstitution + RACE_MODIFIER;
            player.abilityIntelligence = player.abilityIntelligence + RACE_MODIFIER;
            player.abilityWisdom = player.abilityWisdom + RACE_MODIFIER;
            player.abilityCharisma = player.abilityCharisma + RACE_MODIFIER;
            return;
        }
    }

    public void raceDropdownChange()
    {
        //Check to make sure you are not using the Fill in text
        if (raceDD.captionText.text == "SELECT A RACE")
        {
            return;
        }

        //Check to make sure no other modifiers exist
        if (player.raceModExist == true)
        {
            player.raceModExist = false;
            raceModifier(player.race, true);
        }
      
    
        player.race = raceDD.captionText.text;
        raceModifier(player.race, false);
        player.raceModExist = true;
        
        
    }

    public void classDropdownChange()
    {
        //Check to make sure you are not using the Fill in text
        if (classDD.captionText.text == "SELECT A CLASS")
        {
            return;
        }

        player._class = classDD.captionText.text;
    }

    public void alignDropdownChange()
    {
        //Check to make sure you are not using the Fill in text
        if (alignDD.captionText.text == "SELECT AN ALIGNMENT")
        {
            return;
        }

        player.alignment = alignDD.captionText.text;
    }
}