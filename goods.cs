using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class goods : MonoBehaviour,IDragHandler,IPointerUpHandler  
{

	public bool good;

	// Use this for initialization
	void Start () {

		good = false;
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (good == true) 
		{

			transform.parent = item_number.Cell.transform;
			transform.position = item_number.Cell.transform.position;

		}
		
	}

	public void OnDrag(PointerEventData eventData)
	{
		
		good = false;

	}
		

	public void OnPointerUp(PointerEventData eventData)
	{
		
		good = true;

	}

	void OnTriggerStay2D(Collider2D item)
	{



			

	}

	void OnTriggerExit2D(Collider2D item)
	{



	}

}
