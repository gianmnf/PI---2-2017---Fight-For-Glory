using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
	Animator anim;

	public float intervaloDeAtaque;
	private float proximoAtaque;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && Time.time > proximoAtaque) {
			Atacando ();
		}
	}

	void Atacando()
	{
		anim.SetTrigger ("Atacando");
		proximoAtaque = Time.time + intervaloDeAtaque;
	}
}
