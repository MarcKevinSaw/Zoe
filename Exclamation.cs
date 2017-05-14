using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exclamation : MonoBehaviour {


	public Ray ray;
	public RaycastHit2D hit;
	public GameObject exclamation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{



		ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		hit = Physics2D.Raycast (ray.origin, ray.direction, 1000, 256);

		if (Manager.dectect == true && hit.collider && Manager.box == false) 
		{

			exclamation.SetActive (true);
			exclamation.GetComponent<Animator> ().enabled = true;			

		}
		else 
		{

			exclamation.SetActive (false);
			exclamation.GetComponent<Animator> ().enabled = false;

		}
		
	}
		

}
