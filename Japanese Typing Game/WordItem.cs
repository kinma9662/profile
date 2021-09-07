using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordItem : MonoBehaviour
{
    public Text text; //The item text
    public float Speed; //Falling speed
    public GameObject manager; 
    public GameObject hpBar;
    public GameObject Score;

    static public Vector3 speed;
    static public float speedup = 0;

    public void Start()
    {
        hpBar = GameObject.Find("Hp_bar");
        score = GameObject.Find("Score");
        manager = GameObject.Find("Manager");
    }
    public void SetWord(string word) //Get the string from random generated word
    {
        text.text = word; 
    }
    public void WordObjRemove()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        switch (score.GetComponent<score>().lv) //When the score more than the certain quantity, "Speed" will change
        {
            case 0:
                Speed = 1f;
                break;
            case 1:
                Speed = 2f;
                break;
            case 2:
                Speed = 4f;
                break;
            case 3:
                Speed = 10f;
                break;
            case 4:
                Speed = 15f;
                break;
        }
        transform.Translate(0, -Speed * Time.deltaTime, 0f);  //Let the item change the falling speed with the value of "Speed" 

        if (hpBar.GetComponent<hp_bar>().EndGame)   {  Destroy(gameObject); } //When the HP=0, this mean end game, all items will be destroyed 

        if (transform.localPosition.y < -14  ) { text.color = Color.red; } //When the item fall to the certain distance, the color will change to red, notify the player that the item will fall to the bottom

        if (transform.localPosition.y < -33) { //When the item falls to the bottom, it will send message and suicide 
            manager.GetComponent<WordManager>().RemoveCheck(false);  //Send message to "WordManager" :　player was missed this item 
            hpBar.GetComponent<hp_bar>().hurtValue(0.07f); //Send message to "hp_bar" to deduct the HP
            Destroy(gameObject); 
            }
    }
}
