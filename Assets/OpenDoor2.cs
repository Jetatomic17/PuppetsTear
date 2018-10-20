using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OpenDoor2 : MonoBehaviour {

	public Animation hingehere;

	[SerializeField]
	public int distanceToOpenStorage;

	GameObject player;

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance(this.gameObject.transform.position, player.transform.position);

		if (distance <= distanceToOpenStorage && Input.GetKey (KeyCode.E))
			hingehere.Play ();
	}
}
