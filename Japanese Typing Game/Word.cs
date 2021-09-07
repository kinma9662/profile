using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable] 

public class Word //Serialize a custom Japanese letter string
{
	public string word; //Save Japanese letter string
	public string Romanization; //Save romanization of the Japanese character string corresponding to word 
	public int typeIndex; //Save the index value of the string entered by the player 
	WordItem wordItem;

	public Word(string _word, WordItem _wordItem) 
	{
		word = _word; //Get random generated Japanese character string 

		if (_word == "あ") { Romanization = "a"; }
		if (_word == "い") { Romanization = "i"; }
		if (_word == "う") { Romanization = "u"; }
		if (_word == "え") { Romanization = "e"; }
		if (_word == "お") { Romanization = "o"; }
		if (_word == "か") { Romanization = "ka"; }
		if (_word == "き") { Romanization = "ki"; }
		if (_word == "く") { Romanization = "ku"; }
		if (_word == "け") { Romanization = "ke"; }
		if (_word == "こ") { Romanization = "ko"; }
		if (_word == "さ") { Romanization = "sa"; }
		if (_word == "し") { Romanization = "shi"; }
		if (_word == "す") { Romanization = "su"; }
		if (_word == "せ") { Romanization = "se"; }
		if (_word == "そ") { Romanization = "so"; }
		if (_word == "た") { Romanization = "ta"; }
		if (_word == "ち") { Romanization = "chi"; }
		if (_word == "つ") { Romanization = "tsu"; }
		if (_word == "て") { Romanization = "te"; }
		if (_word == "と") { Romanization = "to"; }
		if (_word == "な") { Romanization = "na"; }
		if (_word == "に") { Romanization = "ni"; }
		if (_word == "ぬ") { Romanization = "nu"; }
		if (_word == "ね") { Romanization = "ne"; }
		if (_word == "の") { Romanization = "no"; }
		if (_word == "ま") { Romanization = "ma"; }
		if (_word == "み") { Romanization = "mi"; }
		if (_word == "む") { Romanization = "mu"; }
		if (_word == "め") { Romanization = "me"; }
		if (_word == "も") { Romanization = "mo"; }
		if (_word == "は") { Romanization = "ha"; }
		if (_word == "ひ") { Romanization = "hi"; }
		if (_word == "ふ") { Romanization = "fu"; }
		if (_word == "へ") { Romanization = "he"; }
		if (_word == "ほ") { Romanization = "ho"; }
		if (_word == "や") { Romanization = "ya"; }
		if (_word == "ゆ") { Romanization = "yu"; }
		if (_word == "よ") { Romanization = "yo"; }
		if (_word == "ら") { Romanization = "ra"; }
		if (_word == "り") { Romanization = "ri"; }
		if (_word == "る") { Romanization = "ru"; }
		if (_word == "れ") { Romanization = "re"; }
		if (_word == "ろ") { Romanization = "ro"; }
		if (_word == "わ") { Romanization = "wa"; }
		if (_word == "を") { Romanization = "wo"; }
		if (_word == "ん") { Romanization = "nn"; }
		if (_word == "ア") { Romanization = "a"; }
		if (_word == "イ") { Romanization = "i"; }
		if (_word == "ウ") { Romanization = "u"; }
		if (_word == "エ") { Romanization = "e"; }
		if (_word == "オ") { Romanization = "o"; }
		if (_word == "サ") { Romanization = "sa"; }
		if (_word == "シ") { Romanization = "shi"; }
		if (_word == "ス") { Romanization = "su"; }
		if (_word == "セ") { Romanization = "se"; }
		if (_word == "ソ") { Romanization = "so"; }
		if (_word == "カ") { Romanization = "ka"; }
		if (_word == "キ") { Romanization = "ki"; }
		if (_word == "ク") { Romanization = "ku"; }
		if (_word == "ケ") { Romanization = "ke"; }
		if (_word == "コ") { Romanization = "ko"; }
		if (_word == "タ") { Romanization = "ta"; }
		if (_word == "チ") { Romanization = "chi"; }
		if (_word == "ツ") { Romanization = "tsu"; }
		if (_word == "テ") { Romanization = "te"; }
		if (_word == "ト") { Romanization = "to"; }
		if (_word == "ナ") { Romanization = "na"; }
		if (_word == "ニ") { Romanization = "ni"; }
		if (_word == "ヌ") { Romanization = "nu"; }
		if (_word == "ネ") { Romanization = "ne"; }
		if (_word == "ノ") { Romanization = "no"; }
		if (_word == "ハ") { Romanization = "ha"; }
		if (_word == "ヒ") { Romanization = "hi"; }
		if (_word == "フ") { Romanization = "fu"; }
		if (_word == "ヘ") { Romanization = "he"; }
		if (_word == "ホ") { Romanization = "ho"; }
		if (_word == "マ") { Romanization = "ma"; }
		if (_word == "ミ") { Romanization = "mi"; }
		if (_word == "ム") { Romanization = "mu"; }
		if (_word == "メ") { Romanization = "me"; }
		if (_word == "モ") { Romanization = "mo"; }
		if (_word == "ヤ") { Romanization = "ya"; }
		if (_word == "ユ") { Romanization = "yu"; }
		if (_word == "ヨ") { Romanization = "yo"; }
		if (_word == "ラ") { Romanization = "ra"; }
		if (_word == "リ") { Romanization = "ri"; }
		if (_word == "ル") { Romanization = "ru"; }
		if (_word == "レ") { Romanization = "re"; }
		if (_word == "ロ") { Romanization = "ro"; }
		if (_word == "ワ") { Romanization = "wa"; }
		if (_word == "ヲ") { Romanization = "wo"; }
		if (_word == "ン") { Romanization = "nn"; }
		if (_word == "が") { Romanization = "ga"; }
		if (_word == "ぎ") { Romanization = "gi"; }
		if (_word == "ぐ") { Romanization = "gu"; }
		if (_word == "げ") { Romanization = "ge"; }
		if (_word == "ご") { Romanization = "go"; }
		if (_word == "ざ") { Romanization = "za"; }
		if (_word == "じ") { Romanization = "ji"; }
		if (_word == "ず") { Romanization = "zu"; }
		if (_word == "ぜ") { Romanization = "ze"; }
		if (_word == "ぞ") { Romanization = "zo"; }
		if (_word == "だ") { Romanization = "da"; }
		if (_word == "ぢ") { Romanization = "ji"; }
		if (_word == "づ") { Romanization = "zu"; }
		if (_word == "で") { Romanization = "de"; }
		if (_word == "ど") { Romanization = "do"; }
		if (_word == "ば") { Romanization = "ba"; }
		if (_word == "び") { Romanization = "bi"; }
		if (_word == "ぶ") { Romanization = "bu"; }
		if (_word == "べ") { Romanization = "be"; }
		if (_word == "ぼ") { Romanization = "bo"; }
		if (_word == "ガ") { Romanization = "ga"; }
		if (_word == "ギ") { Romanization = "gi"; }
		if (_word == "グ") { Romanization = "gu"; }
		if (_word == "ゲ") { Romanization = "ge"; }
		if (_word == "ゴ") { Romanization = "go"; }
		if (_word == "ザ") { Romanization = "za"; }
		if (_word == "ジ") { Romanization = "ji"; }
		if (_word == "ズ") { Romanization = "zu"; }
		if (_word == "ゼ") { Romanization = "ze"; }
		if (_word == "ゾ") { Romanization = "zo"; }
		if (_word == "ダ") { Romanization = "da"; }
		if (_word == "ヂ") { Romanization = "ji"; }
		if (_word == "ヅ") { Romanization = "zu"; }
		if (_word == "デ") { Romanization = "de"; }
		if (_word == "ド") { Romanization = "do"; }
		if (_word == "バ") { Romanization = "ba"; }
		if (_word == "ビ") { Romanization = "bi"; }
		if (_word == "ブ") { Romanization = "bu"; }
		if (_word == "ベ") { Romanization = "be"; }
		if (_word == "ボ") { Romanization = "bo"; }
		if (_word == "ぱ") { Romanization = "pa"; }
		if (_word == "ぴ") { Romanization = "pi"; }
		if (_word == "ぷ") { Romanization = "pu"; }
		if (_word == "ぺ") { Romanization = "pe"; }
		if (_word == "ぽ") { Romanization = "po"; }
		if (_word == "パ") { Romanization = "pa"; }
		if (_word == "ピ") { Romanization = "pi"; }
		if (_word == "プ") { Romanization = "pu"; }
		if (_word == "ペ") { Romanization = "pe"; }
		if (_word == "ポ") { Romanization = "po"; }

		typeIndex = 0; 
		wordItem = _wordItem; //Get random generated item
		wordItem.SetWord(word); //Send the string for random generated word
	}

	
	public void Typing()
	{
		typeIndex++; //When the player enter the first char correctly , typeIndex will move forward 
	}
	
	public char NextTest()
	{
		return Romanization[typeIndex]; //Update the new typeIndex
	}
	
	public void WrongType() { typeIndex = 0; } //When the input char is wrong , that will reset the index
	
	public bool WordTyped()
	{
		bool wordTyped = (typeIndex >= Romanization.Length); //When the value of typeIndex equal or more than Romanization.Length
	
		if (wordTyped&&wordItem!=null) //When the wordTyped is true, but the item still exists
		{
			wordItem.WordObjRemove(); 
		}
		return wordTyped; 
	}
	
	public void FailType() //Reset all value used as index
	{
		Romanization = "";
		typeIndex = 0;
		word = "";
	}
}