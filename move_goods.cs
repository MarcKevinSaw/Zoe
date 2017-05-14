using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class move_goods : MonoBehaviour,IPointerDownHandler,IDragHandler,IPointerUpHandler {

	public bool mouse;
	public static bool _mouse;
	public float timer = 0.0f;
	public bool Timer;

	public static GameObject first;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Timer == true) 
		{

			timer += Time.deltaTime;

		}


		if (timer >= 0.1f) 
		{

			mouse = false;
			timer = 0;
			Timer = false;
			_mouse = false;

		}

		if (mouse == false) 
		{

			GetComponent<change_goods> ().enabled = true;
			GetComponent<goods> ().enabled = false;
			GetComponent<BoxCollider2D> ().enabled = false;
			GetComponent<auto_goods> ().enabled = true;

		}

		if (mouse == true) 
		{

			GetComponent<change_goods> ().enabled = false;
			GetComponent<goods> ().enabled = true;
			transform.parent = GameObject.Find ("Canvas").transform;
			GetComponent<BoxCollider2D> ().enabled = true;
			GetComponent<auto_goods> ().enabled = false;

		}
			

	}

	public void OnPointerDown(PointerEventData eventData)
	{

		if (eventData.pointerId == -1) 
		{
			transform.localScale = new Vector3 (0.7f, 0.7f, 0.7f);

			mouse = true;
			_mouse = true;

			if (transform.parent.childCount == 1) {

				first = transform.parent.gameObject;

			} else {

				first = null;

			}

		}

	}

	public void OnDrag(PointerEventData eventData)
	{
		if (eventData.pointerId == -1) 
		{
			
			GetComponent<RectTransform> ().pivot.Set (0, 0);
			transform.position = Input.mousePosition;
	
			mouse = true;

		}

	}

	public void OnPointerUp(PointerEventData eventData)
	{

		if (eventData.pointerId == -1) 
		{
			
			transform.localScale = new Vector3 (1f, 1f, 1f);
			Timer = true;

		}

	}

	void OnTriggerStay2D(Collider2D page)
	{

		if (page.CompareTag ("up")) 
		{

			Manager.bag_page = true;

		}

		if (page.CompareTag ("down")) 
		{

			Manager.bag_page = false;

		}

	}

}
