﻿using UnityEngine;
using System.Collections;

public class pausecontrol : MonoBehaviour {

	public GameObject PauseMenu;
	public bool pause;
	// Use this for initialization
	void Start () {
		PauseMenu.SetActive (false);
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey (KeyCode.Escape)) {
			if(pause == false){
				PauseMenu.SetActive(true);
				pause = true;
			}
				else{
					pause = false;
					PauseMenu.SetActive(false);
				}
		}
	}

	public void resume(){
		PauseMenu.SetActive (false);
		pause = false;
	}

		public void quit(){
		Application.LoadLevel (0);
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (10, 10, 50, 50), "click")) {
			Debug.Log ("you clicked me");
		}
	}


}
