using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
	Animator anim;

	public float intervaloDeAtaque;
	private float proximoAtaque;

	public AudioClip attackSound;
	private AudioSource audioA;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		audioA = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && Time.time > proximoAtaque) {
			Atacando ();
		}
	}

	void Atacando()
	{
		audioA.clip = attackSound;
		audioA.Play ();
		anim.SetTrigger ("Ataque");
		proximoAtaque = Time.time + intervaloDeAtaque;
	}
}
