/*
 * Roswell James Castaneda
 * RED ID: 820249749
 * CS 583 Project 1
 * FileName: DiceSimulator.cs
 * 
 * Script that contains the dice roll function,
 * allows the score to be shown on the ability panel,
 * and saves it to the player data, based on the
 * selected option from the drop down.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceSimulator : MonoBehaviour
{
    
    private Text rollDisplay;
    private Text strDisplay;
    private Text dexDisplay;
    private Text conDisplay;
    private Text intDisplay;
    private Text wisDisplay;
    private Text chaDisplay;
    private Button diceRollButton;
    private Dropdown abilitySelector;
    private Player player;
    System.Random RNG = new System.Random();
    private List<int> rolls = new List<int>(5);
    private List<int> maxValues;
    private List<string> abilities = new List<string>
    {
        "STRENGTH",
        "DEXTERITY",
        "CONSTITUTION",
        "INTELLIGENCE",
        "WISDOM",
        "CHARISMA"
    };

    private void Start()
    {
        //Initialize all Game Objects
        rollDisplay = GameObject.Find("Display_Seven").transform.Find("Text").GetComponent<Text>();
        abilitySelector = GameObject.Find("Ability_Selector_Dropdown").GetComponent<Dropdown>();
        strDisplay = GameObject.Find("Display_One").transform.Find("Text").GetComponent<Text>();
        dexDisplay = GameObject.Find("Display_Two").transform.Find("Text").GetComponent<Text>();
        conDisplay = GameObject.Find("Display_Three").transform.Find("Text").GetComponent<Text>();
        intDisplay = GameObject.Find("Display_Four").transform.Find("Text").GetComponent<Text>();
        wisDisplay = GameObject.Find("Display_Five").transform.Find("Text").GetComponent<Text>();
        chaDisplay = GameObject.Find("Display_Six").transform.Find("Text").GetComponent<Text>();
        player = GameObject.Find("Player").GetComponent<Player>();
        abilitySelector.AddOptions(abilities);
    }

    public List<int> insertionSort(List<int> sortList)
    {
        int LENGTH = sortList.Count;
        int x, y, key;

        for (x = 1; x < LENGTH; x++)
        {
            y = x;
            while (y > 0 && sortList[y - 1] > sortList[y])
            {
                key = sortList[y];
                sortList[y] = sortList[y - 1];
                sortList[y - 1] = key;
                y--;
            }
        }

        return sortList;
    }

    //Function to store ability score based from dropdown input
    public void abilityDropdown(int score)
    {
        string selection = abilitySelector.captionText.text;

        if(selection == "STRENGTH")
        {
            strDisplay.text = score.ToString();
            player.abilityStrength = score; 
        }

        if(selection == "DEXTERITY")
        {
            dexDisplay.text = score.ToString();
            player.abilityDexterity = score;
        }

        if(selection == "CONSTITUTION")
        {
            conDisplay.text = score.ToString();
            player.abilityConstitution = score;
        }

        if (selection == "INTELLIGENCE")
        {
            intDisplay.text = score.ToString();
            player.abilityIntelligence = score;
        }

        if (selection == "WISDOM")
        {
            wisDisplay.text = score.ToString();
            player.abilityWisdom = score;
        }

        if (selection == "CHARISMA")
        {
            chaDisplay.text = score.ToString();
            player.abilityCharisma = score;
        }

    }
    public int rollDice(int NUM_SIDES)
    {
      const int MIN_VAL = 1;
      return RNG.Next(MIN_VAL, NUM_SIDES + 1);
    }

    public void rollButton()
    {
        const int SIX_DIE = 6, MAX_VAL_CAP = 5;
        int value;
        int score = 0;

        value = rollDice(SIX_DIE);
        rollDisplay.text = value.ToString();
        rolls.Add(value);

        //Upon reaching 5 rolls, the score will 
        //be calculated.
       if(rolls.Count == MAX_VAL_CAP)
        {
            //maxValues list now contains sorted rolls
            maxValues = insertionSort(rolls);

            //Grab the three highest rolls
            //Add them together to get high roll
            score = score + maxValues[4];
            score = score + maxValues[3];
            score = score + maxValues[2];

            //put score in selected ability
            abilityDropdown(score);

            rolls.Clear();
       }
    }
}
