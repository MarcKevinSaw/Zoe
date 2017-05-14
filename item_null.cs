using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_null : MonoBehaviour 
{

	public bool Null;
	public bool outpace;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (transform.childCount == 0)
		{

			Null = true;

		}
		else if (transform.childCount >= 1) 
		{

			Null = false;

			if (transform.childCount == 1) 
			{

				outpace = false;

			}
			else if (transform.childCount > 1) 
			{

				outpace = true;

			}

		}

		if (outpace == true) 
		{

			transform.GetChild (0).parent = transform.parent.transform.parent.transform;

		}

	}
}
