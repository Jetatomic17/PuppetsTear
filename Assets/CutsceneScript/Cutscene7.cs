using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene7 : MonoBehaviour {

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
		TextBox.GetComponent<Text> ().text = "What is this? It smells so nasty";

		yield return new WaitForSeconds (4f);
		TextBox.GetComponent<Text> ().text = "Poisonous gases? I shouldńt breath in too much.";

		yield return new WaitForSeconds (7f);

		TextBox.GetComponent<Text> ().text = "I need a gas mask to get around the Library.";

		yield return new WaitForSeconds (6f);

		ThePlayer.SetActive (true);
		Cam1.SetActive (false);

		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);
	}
}
