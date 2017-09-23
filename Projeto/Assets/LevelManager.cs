using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public Transform mainMenu, optionsMenu,levelMenu;
	public void LoadScene (string name) {
		SceneManager.LoadScene(name);
	}
	public void QuitGame(){
		Application.Quit ();	
	}
	public void OptionsMenu(bool clicked){
		if (clicked == true) {
			optionsMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} 
		else {
			optionsMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}
	public void LevelMenu(bool clicked){
		if (clicked == true) {
			levelMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} 
		else {
			levelMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}
}