using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.IO;

public class Resolucao_Tela : MonoBehaviour   {
	// resolucao é o nome do menu de opções.
	public Dropdown resolucao;
	Resolution[] resolutions;

	void Start() {

		resolutions = Screen.resolutions;

		for (int i = 0; i < resolutions.Length; i++)
		{
			resolucao.options.Add (new Dropdown.OptionData (ResToString (resolutions [i])));

			resolucao.value = i;

			resolucao.onValueChanged.AddListener(delegate { Screen.SetResolution(resolutions[resolucao.value].width, resolutions[resolucao.value].height, true);});

		}
	}
	// this goes outside of "void start". it puts resolution options into a string to be displayed in drop menu
	string ResToString(Resolution res)
	{
		return res.width + " x " + res.height;
	}
}