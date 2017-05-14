using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class magnify_goods : MonoBehaviour,IPointerClickHandler {

	public GameObject manify;
	public bool eraser;
	public bool bag = true;
	GameObject x;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		if (eraser == true && Input.GetMouseButtonDown(0)) 
		{

			Destroy (x);
			eraser = false;
			bag_open.blur = false;
			bag_open.timer = 0;
			bag_open.control = false;
			Manager.magnify = false;

		}

	}
	public void OnPointerClick(PointerEventData eventData)
	{

		if (eventData.pointerId == -2) 
		{
			
			x = Instantiate (manify)as GameObject;
			bag_open.start = false;
			bag_open.blur = true;
			x.transform.parent = GameObject.Find ("Bag").transform;
			x.GetComponent<RectTransform> ().localPosition = new Vector2 (0, -2000);
			eraser = true;
			bag_open.control = true;

		}

	}
}
