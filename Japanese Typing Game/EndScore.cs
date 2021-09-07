using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class EndScore : MonoBehaviour //Use in EndGame panal
{
    public Text text; //EndGame panal text

    public Score _score; 

    void Update()
    {
         text.text = _score._score.ToString(); //When call the EndGame panal, will get the score to panal text.
    }
}
