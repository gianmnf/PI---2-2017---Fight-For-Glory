using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Atualizado em 18/11/2017 por Leonardo Braga

public class LevelManager : MonoBehaviour {
	public GameObject aso;
	public Transform mainMenu, optionsMenu,levelMenu,instrucoes,creditos,guerreiro,guerreirofacil,guerreiromedio,guerreirodificil,guerreira,guerreirafacil,guerreiramedio,guerreiradificil;
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
	public void Guerreiro(bool clicked){
		if (clicked == true) {
			guerreiro.gameObject.SetActive (clicked);
			levelMenu.gameObject.SetActive (false);
		} 
		else {
			guerreiro.gameObject.SetActive (clicked);
			levelMenu.gameObject.SetActive (true);
		}
	}
	public void GuerreiroFacil(bool clicked){
		if (clicked == true) {
			guerreirofacil.gameObject.SetActive (clicked);
			guerreiro.gameObject.SetActive (false);
		} 
		else {
			guerreirofacil.gameObject.SetActive (clicked);
			guerreiro.gameObject.SetActive (true);
		}
	}
	public void GuerreiroMedio(bool clicked){
		if (clicked == true) {
			guerreiromedio.gameObject.SetActive (clicked);
			guerreiro.gameObject.SetActive (false);
		} 
		else {
			guerreiromedio.gameObject.SetActive (clicked);
			guerreiro.gameObject.SetActive (true);
		}
	}
	public void GuerreiroDificil(bool clicked){
		if (clicked == true) {
			guerreirodificil.gameObject.SetActive (clicked);
			guerreiro.gameObject.SetActive (false);
		} 
		else {
			guerreirodificil.gameObject.SetActive (clicked);
			guerreiro.gameObject.SetActive (true);
		}
	}
	public void Guerreira(bool clicked){
		if (clicked == true) {
			guerreira.gameObject.SetActive (clicked);
			levelMenu.gameObject.SetActive (false);
		} 
		else {
			guerreira.gameObject.SetActive (clicked);
			levelMenu.gameObject.SetActive (true);
		}
	}
	public void GuerreiraFacil(bool clicked){
		if (clicked == true) {
			guerreirafacil.gameObject.SetActive (clicked);
			guerreira.gameObject.SetActive (false);
		} 
		else {
			guerreirafacil.gameObject.SetActive (clicked);
			guerreira.gameObject.SetActive (true);
		}
	}
	public void GuerreiraMedio(bool clicked){
		if (clicked == true) {
			guerreiramedio.gameObject.SetActive (clicked);
			guerreira.gameObject.SetActive (false);
		} 
		else {
			guerreiramedio.gameObject.SetActive (clicked);
			guerreira.gameObject.SetActive (true);
		}
	}
	public void GuerreiraDificil(bool clicked){
		if (clicked == true) {
			guerreiradificil.gameObject.SetActive (clicked);
			guerreira.gameObject.SetActive (false);
		} 
		else {
			guerreiradificil.gameObject.SetActive (clicked);
			guerreira.gameObject.SetActive (true);
		}
	}
	public void Music(){
		Destroy (aso);
	}
}