using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text; //Score text
    public int _score = 0; //Score value
    public int lv = 0; //Item falling speed

    void Update()
    {
        text.text = _score.ToString(); //Set up "text" to save score value
        if (_score > 15) { lv = 1; }  //When the score reach a certain value, item falling speed will change according to the LV 
         if (_score > 40) { lv = 2; }
         if (_score > 75) { lv = 3; }
         if (_score > 100) { lv = 4; }
    }
    public void addScore(int score)
    {
        _score += score; //When the player successful the score, will call this function to add the score
    }
}
