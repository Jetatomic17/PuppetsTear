using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achtrigger : MonoBehaviour {

	public GameObject Panelss;
	
	void OnTriggersEnter(Collider other)
	{
		if(other.gameObject.tag=="Player")
		{
		Panelss.gameObject.SetActive(true);
		} else {
			Panelss.gameObject.SetActive(false);
		}
		}
	}




	