using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp_bar : MonoBehaviour
{
    public Image hpbar; //Item from HP Bar
    public GameObject EndgameObj; //EndGame Panel
    public bool EndGame; //Boolean for decide whether EndGame
    
	void Start()
    {
        hpbar = GetComponent<Image>(); 
        EndgameObj.SetActive(false); //EndgameObj&EngGame all default to false 
        EndGame = false;
        Time.timeScale = 1; //Set the game time to normal speed
    }
    private void Update()
    {
        hpbar.fillAmount -= 0.0003f; //Set the hpbar, hpbar will reverse speed 
        if (hpbar.fillAmount == 0) { EndGame = true; Time.timeScale = 0; EndgameObj.SetActive(true); } // When EndGame will open the EndGame Panel and stop the game time 
        if (hpbar.fillAmount < 0.2f)
        {
            hpbar.color = Color.red; //When the hpbar reach a certain value, the color will hue as red, notify the player that no more time
        }
        else if (hpbar.fillAmount < 0.4f) 
        {
            hpbar.color = Color.yellow; //When the hpbar reach a certain value, the color will hue as yellow, notify the player time's running out
        }
        else
        {
            hpbar.color = Color.green; //When healthy the Hpbar as green
        }
    }
    public void hurtValue(float value)
    {
        hpbar.fillAmount -= value; //When the player miss the item, that will deduct the Hp value
    }
    public void RecoveryValue(float value)
    {
        hpbar.fillAmount += value; //When the player successful the score, that will add Hp value 
    }
}
