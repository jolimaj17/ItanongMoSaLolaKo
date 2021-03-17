using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
public class TextBoxQuiz : MonoBehaviour {
	[SerializeField]
	private Text trueText;
	[SerializeField]
	private Text FalseText;
	private int score = 5;
	private GameObject a;

	[SerializeField]
	private Text scoretext;

	[SerializeField]
	public InputField ip;
	[SerializeField]
	private Text helptext;
	private string a1;
	void Awake () {
		a1="william howard taft";

	}
	public void GetIn(string guess){
		Compare  (guess);
		ip.text = "";
	}
	// Update is called once per frame
	public void Compare (string guess) {
		if (guess == a1) {
			score = score + 0;
			scoretext.text = score.ToString ();
			ScoreManager.AddCoins (score);
			trueText.text = "";
		} else if (guess != a1){
			HealthControlScript.health -= 1;
			PlayerPrefs.SetInt ("Coins", HealthControlScript.health);
			FalseText.text = "";
		}
	}
}
