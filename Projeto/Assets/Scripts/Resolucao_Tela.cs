using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.IO;

public class Resolucao_Tela : MonoBehaviour   {
	// Resolucao é o nome do menu de opções.
	public Dropdown Resolucao;
	Resolution[] resolutions;

	void Start() {

		resolutions = Screen.resolutions;

		for (int i = 0; i < resolutions.Length; i++)
		{
			Resolucao.options.Add (new Dropdown.OptionData (ResToString (resolutions [i])));

			Resolucao.value = i;

			Resolucao.onValueChanged.AddListener(delegate { Screen.SetResolution(resolutions[Resolucao.value].width, resolutions[Resolucao.value].height, true);});

		}
	}
	// this goes outside of "void start". it puts resolution options into a string to be displayed in drop menu
	string ResToString(Resolution res)
	{
		return res.width + " x " + res.height;
	}
}