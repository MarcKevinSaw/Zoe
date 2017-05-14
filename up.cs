using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class up : MonoBehaviour,IPointerClickHandler,IPointerDownHandler 
{



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Manager.bag_page == true) 
		{

			GetComponent<Image> ().color = new Color32 (100, 100, 100, 255);
			GameObject.Find ("page1").transform.parent = GameObject.Find ("Bag").transform;

		}
		if (Manager.bag_page == false) 
		{

			GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			GameObject.Find ("page1").transform.parent = GameObject.Find ("InPage").transform;

		}
		
	}

	public void OnPointerClick(PointerEventData eventData)
	{

		if (eventData.pointerId == -1) 
		{

			Manager.bag_page = true;

		}

	}

	public void OnPointerDown(PointerEventData eventData)
	{

		if (eventData.pointerId == -1) 
		{

			GetComponent<Image> ().color = new Color32 (100, 100, 100, 255);

		}

	}
}

