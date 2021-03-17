using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvManager : MonoBehaviour {

	Button[] lvbtn;
	 int reac,curre; 
	void Awake () {
		 reac= PlayerPrefs.GetInt ("reach", reac);

		lvbtn = new Button[transform.childCount];

		for (int i = 0; i < lvbtn.Length; i++) {

			lvbtn [i] = transform.GetChild (i).GetComponent<Button> ();
			lvbtn [i].GetComponentInChildren<Text> ().text = (i + 1).ToString ();
		
		
			if (i + 1 > reac) {
				lvbtn [i].interactable = false;
			} 
		}


	}
	public void Play(string a){
		curre= PlayerPrefs.GetInt ("reach", curre);
		GameObject.Find (a);
	}
	public void goNext(){
		curre= PlayerPrefs.GetInt ("reach", curre);
		SceneManager.LoadScene ("GameBegin");
	}

}
