using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice2 : MonoBehaviour {

	public static bool Ans2;
	public GameObject Yes;
	public GameObject No;

	// Use this for initialization
	void Start () 
	{

		this.transform.position = Yes.transform.position;

	}

	// Update is called once per frame
	void Update () 
	{

		if (Manager.dectect == true)
		{

			if (mouse_choice.A == true) 
			{

				this.transform.position = Yes.transform.position;

			} 
			else if (mouse_choice.A == false)
			{

				this.transform.position = No.transform.position;

			}

		}

		if(Manager.box == false)
			this.transform.position = Yes.transform.position;

	}

	void OnTriggerStay2D(Collider2D C)
	{

		if (C.CompareTag ("yes")) 
		{

			Ans2 = true;

		}

		if (C.CompareTag ("no")) 
		{

			Ans2 = false;

		}


	}
}
