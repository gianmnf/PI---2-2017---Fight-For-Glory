using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour {

	public Slider musicVolume;
	public Slider soundVolume;
	public AudioSource Music;
	public AudioSource Sounds;
	
	// Update is called once per frame
	void Update () {
		Music.volume = musicVolume.value;
	}
}
