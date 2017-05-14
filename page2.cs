using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class page2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{

		if (Manager.bag_page == true)
			GetComponent<item_number> ().enabled = false;

		if (Manager.bag_page == false)
			GetComponent<item_number> ().enabled = true;

	}
}
