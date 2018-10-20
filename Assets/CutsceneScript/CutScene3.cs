﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutScene3 : MonoBehaviour {

	public GameObject Cam1;

	public GameObject ThePlayer;
	public GameObject TheCanvas;
	public GameObject TextBox;

	void OnTriggerEnter(){
		StartCoroutine (CutSceneShow ());
	}


	IEnumerator CutSceneShow() {
		//TheCanvas.SetActive (false);
		Cam1.SetActive (true);
		ThePlayer.SetActive (false);
		TextBox.GetComponent<Text> ().text = "Wait...";
		yield return new WaitForSeconds (3f);
		TextBox.GetComponent<Text> ().text = "Why thereś a wall over here? I'm trapped!";
		yield return new WaitForSeconds (3f);


		ThePlayer.SetActive (true);
		Cam1.SetActive (false);

		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);
	}
}