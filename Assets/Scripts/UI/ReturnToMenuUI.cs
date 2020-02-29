/*
 * Roswell James Castaneda
 * RED ID: 820249749
 * CS 583 Project 1
 * FileName: ReturnToMenuUI.cs
 * 
 * Script for return to menu button in
 * Character creation menu.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenuUI : MonoBehaviour
{
    public void RTMButton()
    {
        SceneManager.LoadScene(0);
    }
}
