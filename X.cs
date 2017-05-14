using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class X : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {

	public static bool closs = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerDown(PointerEventData eventData)
	{

		if (eventData.pointerId == -1) 
		{
			
			this.GetComponent<Image> ().color = new Color32 (175, 175, 175, 255);

		}

	}

	public void OnPointerUp(PointerEventData eventData)
	{

		if (eventData.pointerId == -1) 
		{

			this.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			closs = true;

		}

	}

}
