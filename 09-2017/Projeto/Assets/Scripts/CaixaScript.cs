using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaScript : MonoBehaviour {

	Animator anim;

	public float jumpForce;
	public int moedas;
	public GameObject moedaPrefab;

	public AudioClip[] audios;
	AudioSource audioA;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		audioA = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			audioA.clip = audios [0];
			audioA.Play ();
			other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			other.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpForce));
			anim.SetTrigger ("Colidindo");
			if (moedas > 0) {
				GameObject tempmoeda = Instantiate (moedaPrefab, transform.position, transform.rotation) as GameObject;
				tempmoeda.GetComponent<Animator> ().SetTrigger ("Coletando");
				tempmoeda.GetComponent<AudioSource> ().Play ();
				moedas -= 1;
				GameManager.gm.SetMoedas (1);
				Destroy (tempmoeda, 0.167f);
			}
			else {
				audioA.clip = audios [1];
				AudioSource.PlayClipAtPoint(audios[1], transform.position);
				Destroy (gameObject);
			}
		}
	}
}
