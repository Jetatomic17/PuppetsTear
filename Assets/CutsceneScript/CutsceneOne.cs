using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneOne : MonoBehaviour {

	public GameObject Cam1;
	public GameObject Cam2;
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
		TextBox.GetComponent<Text> ().text = "The Library....";
		yield return new WaitForSeconds (4.5f);
		Cam2.SetActive (true);
		Cam1.SetActive (false);
		TextBox.GetComponent<Text> ().text = "I should search the other rooms";
		yield return new WaitForSeconds (4.5f);
		ThePlayer.SetActive (true);
		Cam2.SetActive (false);
		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);

	}
}
