﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fim : MonoBehaviour {

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.M))
		{
			SceneManager.LoadScene ("Menu");
		}
	}
}