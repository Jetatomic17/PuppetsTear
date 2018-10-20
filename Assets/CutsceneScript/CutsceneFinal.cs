using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CutsceneFinal : MonoBehaviour {
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
		TextBox.GetComponent<Text> ().text = "An Elevator! Now I can escape from this place!";

		yield return new WaitForSeconds (5f);
		TextBox.GetComponent<Text> ().text = "Time to go Home!";

		yield return new WaitForSeconds (2f);


		//ThePlayer.SetActive (true);
		//Cam1.SetActive (false);

		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);
		Application.LoadLevel (6);

	}


}
