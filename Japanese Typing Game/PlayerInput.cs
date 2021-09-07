using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public WordManager wordmanager;
    void Update()
    {
        foreach (char test in Input.inputString) //Set up a "test" to save the char entered by the player 
        {
            wordmanager.Typing(test); //Then send the "test" to "WordManager"
        }
    }
}