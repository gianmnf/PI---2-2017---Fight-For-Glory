using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Qualidade : MonoBehaviour {
	public Button Baixa;
	public Button Media;
	public Button Alta;
	void Start () {
		Baixa = Baixa.GetComponent<Button> ();
		Media = Media.GetComponent<Button> ();
		Alta = Alta.GetComponent<Button> ();
	}
	public void baixa()
	{
		QualitySettings.SetQualityLevel (0);
	}
	public void media()
	{
		QualitySettings.SetQualityLevel (1);
	}
	public void alta()
	{
		QualitySettings.SetQualityLevel (2);
	}
}
