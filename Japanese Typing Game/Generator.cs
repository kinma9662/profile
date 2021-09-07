using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
	private static string[] wordList; //Save item "50 hiragana" to List
	public int LV; //Difficulty Lv
	private static string[] wordList4 = { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "を", "ん", "ア", "イ", "ウ", "エ", "オ", "カ", "キ", "ク", "ケ", "コ", "サ", "シ", "ス", "セ", "ソ", "タ", "チ", "ツ", "テ", "ト", "ナ", "ニ", "ヌ", "ネ", "ノ", "ハ", "ヒ", "フ", "ヘ", "ホ", "マ", "ミ", "ム", "メ", "モ", "ヤ", "ユ", "ヨ", "ラ", "リ", "ル", "レ", "ロ", "ワ", "ヲ", "ン", "が", "ぎ", "ぐ", "げ", "ご", "ガ", "ギ", "グ", "ゲ", "ゴ", "ざ", "じ", "ず", "ぜ", "ぞ", "ザ", "ジ", "ズ", "ゼ", "ゾ", "だ", "ぢ", "づ", "で", "ど", "ダ", "ヂ", "ヅ", "デ", "ド", "ば", "び", "ぶ", "べ", "ぼ", "バ", "ビ", "ブ", "ベ", "ボ", "ぱ", "ぴ", "ぷ", "ぺ", "ぽ", "パ", "ピ", "プ", "ペ", "ポ"};

	private static string[] wordList3 = { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "を", "ん", "ア", "イ", "ウ", "エ", "オ", "カ", "キ", "ク", "ケ", "コ", "サ", "シ", "ス", "セ", "ソ", "タ", "チ", "ツ", "テ", "ト", "ナ", "ニ", "ヌ", "ネ", "ノ", "ハ", "ヒ", "フ", "ヘ", "ホ", "マ", "ミ", "ム", "メ", "モ", "ヤ", "ユ", "ヨ", "ラ", "リ", "ル", "レ", "ロ", "ワ", "ヲ", "ン" };
	private static string[] wordList2 = { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "を", "ん" };
	private static string[] wordList1 = { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の" };

    private void Start()
    {
		switch (LV) //When player choose the Lv, will make "wordList" change to the "list" of each difficulty 
		{
			case 1:
				wordList = wordList1;
				break;
			case 2:
				wordList = wordList2;
				break;
			case 3:
				wordList = wordList3;
				break;
			case 4:
				wordList = wordList4;
				break;
		}

	}

    public static string GetRandomWord()
	{
		int randomIndex = Random.Range(0, wordList.Length); //Set up the index for random generated items
		string randomWord = wordList[randomIndex]; //Set up "randomWord" to save the random generated value 
		return randomWord;
	}
}
