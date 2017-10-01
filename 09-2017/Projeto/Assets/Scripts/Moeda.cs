using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour {

	Animator anim;
	CircleCollider2D col;

	AudioSource audioA;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		col = gameObject.GetComponent<CircleCollider2D> ();
		audioA = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			audioA.Play ();
			GameManager.gm.SetMoedas (1);
			col.enabled = false;
			anim.SetTrigger ("Coletando");
			Destroy (gameObject, 0.167f);
		}
	}
}
