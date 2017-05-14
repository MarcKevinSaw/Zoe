using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_goods : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{


		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.parent.gameObject == GameObject.Find("Canvas") && GetComponent<move_goods> ().mouse == false) 
		{

			transform.parent = bag_gameobject._null.transform;
			transform.position = bag_gameobject._null.transform.position;

		}
		
	}
}
