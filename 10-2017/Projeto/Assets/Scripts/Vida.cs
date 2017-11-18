using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Vida : MonoBehaviour
{

	Animator anim;

	AudioSource audioS;
	// Use this for initialization
	void Start ()
	{
		anim = gameObject.GetComponent<Animator> ();
		audioS = gameObject.GetComponent<AudioSource> ();
	}
	
	public void ganhavida()
	{
		audioS.Play ();
		anim.SetTrigger ("Collected");
	}
}