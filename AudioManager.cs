using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {


	public bool mute; 
	public AudioSource music;

	void Start ()
	{
		music.volume=PlayerPrefs.GetFloat("mute");

	}

	void  Update()
	{
		music.volume = music.volume;
	
	}

	public void Muted ()
	{
		mute = !mute;

			gameObject.GetComponent<AudioSource> ().volume = 0;
			PlayerPrefs.SetFloat("mute",music.volume);
		
	}
	public void NotMuted ()
	{
		gameObject.GetComponent<AudioSource> ().volume = 1;
		PlayerPrefs.SetFloat("mute", music.volume);
	}

}
