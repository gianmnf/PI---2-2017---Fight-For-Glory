using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public Transform mainMenu, optionsMenu,levelMenu,instrucoes,creditos;
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
	public void Instrucoes(bool clicked){
		if (clicked == true) {
			instrucoes.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} 
		else {
			instrucoes.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}

	public void Creditos(bool clicked){
		if (clicked == true) {
			creditos.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} 
		else {
			creditos.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}
}