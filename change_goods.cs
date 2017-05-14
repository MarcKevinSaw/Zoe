using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class change_goods : MonoBehaviour  {

	public bool closs;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (transform.parent.childCount > 1) 
		{

			closs = true;

			transform.parent = move_goods.first.transform;
			transform.position = move_goods.first.transform.position;

		}
		else 
		{

			closs = false;

		}
			
	}
		
}
