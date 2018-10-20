using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class AOpening : MonoBehaviour {

	public GameObject ThePlayer;
	public GameObject FadeScreenIn;
	public GameObject TextBox;

	void Start () {
		ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
		StartCoroutine (ScenePlayer ());
	}

	IEnumerator ScenePlayer () {
		yield return new WaitForSeconds (1.5f);
		FadeScreenIn.SetActive (false);
		TextBox.GetComponent<Text> ().text = "....................";
		yield return new WaitForSeconds (3);
		TextBox.GetComponent<Text> ().text = "..........................!";
		yield return new WaitForSeconds (3);
		TextBox.GetComponent<Text> ().text = "Where am I?";
		yield return new WaitForSeconds (3);
		TextBox.GetComponent<Text> ().text = ".........";
		yield return new WaitForSeconds (3);
		TextBox.GetComponent<Text> ().text = "The study room? Why am I here?";
		yield return new WaitForSeconds (3);
		TextBox.GetComponent<Text> ().text = "I need to find my way out";
		yield return new WaitForSeconds (5);
		TextBox.GetComponent<Text> ().text = "";
		ThePlayer.GetComponent<FirstPersonController> ().enabled = true;

	}

}