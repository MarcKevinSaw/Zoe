using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bag_gameobject : MonoBehaviour {

	int i = 1;
	public int j;
	public static GameObject _null;


	// Use this for initialization

	
	// Update is called once per frame
	void Update () 
	{

		for (i = 0; i < 30; i++) 
		{
			
			if (i < 15) 
			{
				
				if (GameObject.Find ("page1").transform.GetChild (i).GetComponent<item_null> ().Null == true) 
				{

					_null = GameObject.Find ("page1").transform.GetChild (i).gameObject;
					i = 30;

				}

			}
			else if (i >= 15) 
			{

				if (GameObject.Find ("page2").transform.GetChild (i-15).GetComponent<item_null> ().Null == true) 
				{

					_null = GameObject.Find ("page2").transform.GetChild (i-15).gameObject;
					i = 30;

				}

			}

		}

		j = _null.GetComponent<PickUpDrop> ().gridID;
		
	}
}
