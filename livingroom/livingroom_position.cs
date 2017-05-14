using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livingroom_position : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{


		if (livingroom_manager.Posion != null) 
		{
			
			this.transform.position = livingroom_manager.Posion;
		
		}

	}

	// Update is called once per frame
	void Update () 
	{

		livingroom_manager.Posion = this.transform.position;

	}
}
