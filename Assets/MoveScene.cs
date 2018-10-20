using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MoveScene : MonoBehaviour {

	[SerializeField] private int y;
	public GameObject TextBox;
	public GameObject TextBox2;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Player")
		{
			//int y = SceneManager.GetActiveScene().buildIndex;
			//SceneManager.LoadScene(y);

			TextBox.GetComponent<Text> ().text = "Achievement earned : Congratulations! You escaped from the library!";
			TextBox2.GetComponent<Text> ().text = "You escaped from the Library!";


		


		}
	}
}
