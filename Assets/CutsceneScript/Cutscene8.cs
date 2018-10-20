using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cutscene8 : MonoBehaviour {

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
		TextBox.GetComponent<Text> ().text = "An electricity room...";

		yield return new WaitForSeconds (4f);
		TextBox.GetComponent<Text> ().text = "I need to place fuses in here to open the exit door";

		yield return new WaitForSeconds (5f);

		TextBox.GetComponent<Text> ().text = "A Dead body??";

		yield return new WaitForSeconds (4f);

		ThePlayer.SetActive (true);
		Cam1.SetActive (false);

		TextBox.GetComponent<Text> ().text = "";
		//TheCanvas.SetActive (true);
		Destroy (gameObject);
	}
}
