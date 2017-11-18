using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {
	public GameObject aso;

	public void LoadScene (string name) {
		SceneManager.LoadScene(name);
		Destroy (aso);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}