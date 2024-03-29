﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static GameManager gm;
	public string name;
	public GameObject other;
	public GameObject musica;
	private int vidas = 2;
	private int moedas = 0;

	void Awake () { //Chama função antes do objeto
		if (gm == null) {
			gm = this;
			DontDestroyOnLoad (gameObject);
		} 
		else
			Destroy (gameObject);
	}
	
	void Start(){
		AtualizaHud ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Destroy (musica);
			SceneManager.LoadScene (name);
		}
	}
	public void SetVidas(int vida)
	{
		vidas += vida;
		if(vidas >= 0) 
		AtualizaHud ();
	}

	public int GetVidas()
	{
		return vidas;
	}

	public void SetMoedas(int moeda)
	{
		moedas += moeda;
		if (moedas >= 50) 
		{
			moedas = 0;
			vidas += 1;
			other.GetComponent<Vida> ().ganhavida ();
		}

		AtualizaHud ();
	}

	public void AtualizaHud()
	{
		GameObject.Find ("VidasText").GetComponent<Text> ().text = vidas.ToString ();
		GameObject.Find ("MoedaText").GetComponent<Text> ().text = moedas.ToString ();
	}

	void OnLevelWasLoaded()
	{
		if (SceneManager.GetActiveScene ().buildIndex == 1) 
		{
			vidas = 2;
			moedas = 0;
		}
}
}