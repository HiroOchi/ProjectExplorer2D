﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void Iniciar(){
		SceneManager.LoadScene ("Mapa Com Colisao Editada");
	}

	public void SairDoJogo(){
		Application.Quit ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
