using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadorReset : MonoBehaviour {

	public Text tx,tx1;
	
	int score=0;
	[SerializeField]
	private Text Reset;
	public void Save(){
	
		PlayerPrefs.SetInt ("Score", score);
	}
	public void Load(){

	tx = GetComponent<Text> ();
	ScoreManager.Score = PlayerPrefs.GetInt ("Score",ScoreManager.Score);
	
	if (PlayerPrefs.HasKey ("Score")) {
	}tx1.text = score.ToString (); 
//		SceneManager.LoadScene ( PlayerPrefs.GetInt("Level") );
//		print ("Game loaded!");
	}
	public void Delete(){
		
		Reset.text="Game was Reset";
		PlayerPrefs.DeleteAll ();
		SceneManager.LoadScene ("Menu");
	}
}
