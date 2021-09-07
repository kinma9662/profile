using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
	public List<Word> words; //Set up "word" List to save Japanese letter string from "Word" 
	public Spawner Spawner;

	public bool hasActive; //Determine if the player is typing the char of this item 
	public Word activeObj; 
	public Score _score;
	public hp_bar hpBar;
	public int LV; //This level is preset, when the player chooses the difficulty , that will enter the corresponding scene, than the Generator will corresponding the lv to setup difficulty of wordList 

	void Update()
	{
		if (hasActive && activeObj.WordTyped()) //When it is judged that the player is entering the char of this item , and the typeIndex equal or more Romanization.Length with this item 
		{
			_score.addScore(15); 
			hpBar.RecoveryValue(0.03f); //Add score && add Hp value 
			hasRemove(); //Function of Destroy item
		}
		if (hpBar.EndGame) { words.Clear(); } //When EndGame will reset the "words" List 
	}

	public void AddWord() //Spawn the word item, and make "words"list get them
	{
			Word word = new Word(Generator.GetRandomWord(), Spawner.SpawnWord()); //Call the "Generator" function to get random generated value of wordList, call the "Spawner" function to get random generated value of wordObj
			words.Add(word); //Get the value of random generated item
	}	
	public void RemoveCheck(bool remove_check)  //When the item has miss
	{
		bool check_ = true;
		if (check_) { FailRemove(); check_ = false; } //Let FailRemove run once
	}
	public void FailRemove() //This function just when the item has miss
	{
		hasActive = false; //Reset the hasActive
		words.RemoveAt(0); //Remove the current "word" 
		activeObj.FailType(); //Call the function from "Word", reset all value used as index
	}
	public void hasRemove()  //This function just when the item has complite
	{
		hasActive = false; //Reset the hasActive
		words.Remove(activeObj); //Remove the current "word" 
		activeObj.FailType(); //Call the function from "Word", reset all value used as index
	}
	
	
	public void Typing(char test) //Determine the char entered by the player 
	{
		if (hasActive) //Check whether the first char is entered correctly
		{
			if (activeObj.NextTest() != test) //Check whether the 2nd or above char is entered correctly
			{
				activeObj.WrongType(); //When the char is wrong, it will reset the typeIndex
				hasActive = false; // Reset the hasActive
			}
			else if (activeObj.NextTest() == test)
			{
				activeObj.Typing(); //When the char correctly , typeIndex will move forward 
			}
		}
		else
		{
			foreach (Word word in words) //Check the items currently generated in "words"List
			{
				if (word.NextTest() == test) //Check that the player is typing the char of this item 
				{
					activeObj = word; //Get the value of word
					hasActive = true;
					word.Typing(); //Set typeIndex move forward 
					break;
				}
			}
		}

	}
}