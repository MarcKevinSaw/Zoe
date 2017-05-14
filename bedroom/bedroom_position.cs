using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedroom_position : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{



		if (bedroom_manager.POsion != null) 
		{


			this.transform.position = bedroom_manager.POsion;

		}

	}

	// Update is called once per frame
	void Update () 
	{


		bedroom_manager.POsion = this.transform.position;

	}
}
