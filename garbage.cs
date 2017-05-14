using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbage : MonoBehaviour
{

	public bool Exit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Exit == true && Input.GetMouseButtonUp(0))
		{

			Destroy (gameObject);

		}
		
	}
		

	void OnTriggerStay2D(Collider2D item)
	{

		if (item.CompareTag ("Garbage")) 
		{

			Exit = true;

		}

	}

	void OnTriggerExit2D(Collider2D item)
	{

		Exit = false;

	}


}
