﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;


public class upLevel : MonoBehaviour {

	public void OnBeginButtonClicked (){
		SceneManager.LoadScene (1);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
