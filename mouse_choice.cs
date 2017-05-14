using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_choice : MonoBehaviour {

	public static bool A = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Manager.box == false)
			A = true;

	}

	void OnTriggerStay2D(Collider2D C)
	{
		if (Manager.dectect == true && Manager.box == true) 
		{
			
			if (C.CompareTag ("yes")) {

				A = true;

			}

			if (C.CompareTag ("no")) {

				A = false;

			}

		}

	}

}
