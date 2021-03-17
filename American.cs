using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class American : MonoBehaviour {

	private int index;
	private GameObject[] level;
	private void Start(){
		index = PlayerPrefs.GetInt ("American",index);
		level=new GameObject[transform.childCount];
		for(int i=0;i<transform.childCount;i++)
			level[i]=transform.GetChild(i).gameObject;
		foreach(GameObject go in level){
			go.SetActive(false);

			if(level[index])
				level[index].SetActive(true);
		}
	}
	public void ToggleLeft(){
		level[index].SetActive(false);
		index--;
		if(index==level.Length)
			index=level.Length-2;
		level[index].SetActive(true);
	}
	public  void ToggleRight(bool isLeft){
		level[index].SetActive(false);
		index++;
		if(index==level.Length)
			index=0;
		level[index].SetActive(true);
	}

	public void confirm(){
		PlayerPrefs.SetInt ("American", index);

	}

	public void NextScene(string SN){

		SceneManager.LoadScene (SN);
	}
	public void ga(string a){
		GameObject.Find (a);
	}
	public void trivia(string a){
		if (GameObject.Find ("Trivia1")) {
			GameObject.Find (a);

		}
		else if (GameObject.Find ("STrivia1")) {
			GameObject.Find (a);
		}
		else if (GameObject.Find ("ATrivia1")) {
			GameObject.Find (a);
		}
		else if (GameObject.Find ("JTrivia1")) {
			GameObject.Find (a);
		}
	}
}
