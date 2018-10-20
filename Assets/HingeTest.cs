using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 75, 0), 2 * Time.deltaTime);
	}
}
