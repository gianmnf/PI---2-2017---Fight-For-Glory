﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PassaFase : MonoBehaviour {
	public GameObject levelMusic;
	public string cena;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
				SceneManager.LoadScene(cena);
				Destroy (levelMusic);
		}	
	}
}