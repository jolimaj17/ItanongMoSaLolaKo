using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	
	public static int Score;
	public int coinsToAdd;

	Text text;

	void Start () {
		text = GetComponent<Text> ();
		Score = PlayerPrefs.GetInt ("Coins", Score);

	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0)
			Score = 0;
		text.text = "" + Score;
	}

	//code for add score
	public static void AddCoins(int CoinsToAdd){
		Score += CoinsToAdd;
		PlayerPrefs.SetInt ("Coins", Score);
		if (Score == null)
			Score = 0;
		
	}

	public void reset(){
		
		PlayerPrefs.DeleteAll();

	}


}
