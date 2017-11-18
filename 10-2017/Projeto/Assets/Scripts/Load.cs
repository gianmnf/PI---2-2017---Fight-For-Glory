using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour {

	public GameObject mus;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CarregaNivel(string cena)
	{
		SceneManager.LoadScene (cena);
	}

	public void Sair()
	{
		Application.Quit ();
	}

	public void StopMusic(){
		Destroy (mus);
	}
}