using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject wordPrefab; //The GameObject from random generated "50 Hiragana"
	public Transform wordCanvas; //Get Canvas position
	public WordManager wordManager;

	public float wordDelay = 5.5f; //Set up spawn time interval 
	private float nextWordTime = 0f; //Set up the waiting time


	private void Update()
	{
		if (Time.time >= nextWordTime) //Whem real time more than nextWordTime
		{
			wordManager.AddWord(); //Call the "AddWord" function to spawn the item
			nextWordTime = Time.time + wordDelay; //Make nextWordTime save the sum of "Time.time + wordDelay"
		}
	}
	public WordItem SpawnWord() //Spawn item function
	{
		Vector3 randomPosition = new Vector3(Random.Range(-2.4f, 2.4f), 4.2f); //Random spawn the X value
		GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas); //Spawn the wordPrefab from subobject by Canvas 
		WordItem word_item = wordObj.GetComponent<WordItem>(); //Get the value from wordObj

		return word_item; 
	}
}
