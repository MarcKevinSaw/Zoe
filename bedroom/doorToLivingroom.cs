using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorToLivingroom : MonoBehaviour {

	public bool Door;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.W) && Door == true) 
		{

			Application.LoadLevel ("livingroom");

		}
		
	}

	void OnTriggerStay2D(Collider2D door)
	{

		if (door.CompareTag  ("Player")) 
		{

			Door = true;

		}

	}

	void OnTriggerExit2D(Collider2D door)
	{

		if (door.CompareTag  ("Player")) 
		{

			Door = false;

		}
	}

}
