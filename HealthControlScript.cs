using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthControlScript : MonoBehaviour {

	//variable
	public GameObject h1,h2,h3;
	public static int health;

	void Start () {
		health = 3;
		h1.gameObject.SetActive (true);
		h2.gameObject.SetActive (true);
		h3.gameObject.SetActive (true);
		health = PlayerPrefs.GetInt ("health", health);
	}
	
	// code for health
	void Update () {
		PlayerPrefs.SetInt ("health", health);
		if(health>3)
			health = 3;
	
		switch(health){
		case 3:
			h1.gameObject.SetActive (true);
			h2.gameObject.SetActive (true);
			h3.gameObject.SetActive (true);
			break;

		case 2:
			h1.gameObject.SetActive (true);
			h2.gameObject.SetActive (true);
			h3.gameObject.SetActive (false);
			break;

		case 1:
			h1.gameObject.SetActive (true);
			h2.gameObject.SetActive (false);
			h3.gameObject.SetActive (false);
			break;

		case 0:
			h1.gameObject.SetActive (false);
			h2.gameObject.SetActive (false);
			h3.gameObject.SetActive (false);
			break;

	}


}

}
