﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene(1);	
	}
	public void QuitGame(){
		Application.Quit ();
	}
	public void BackToMain(){
		SceneManager.LoadScene(0);
	}
	public void NextLevel(){
		SceneManager.LoadScene(2);
	}
}
