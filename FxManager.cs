using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxManager : MonoBehaviour {

	public bool fxx; 

	public AudioSource fx;
	void Start ()
	{
		
		fx.volume=PlayerPrefs.GetFloat("fx");
	}

	void  Update()
	{
		
		fx.volume = fx.volume;
	}

	public void Mutedfx ()
	{
		fxx = !fxx;

		gameObject.GetComponent<AudioSource> ().volume = 0;
		PlayerPrefs.SetFloat("fx",fx.volume);

	}
	public void NotMutedfx ()
	{
		gameObject.GetComponent<AudioSource> ().volume = 1;
		PlayerPrefs.SetFloat("fx", fx.volume);
	}
}