using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class text01_goods : MonoBehaviour,IPointerClickHandler {

	public bool box;
	public string TEXT;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (box == true && Input.GetMouseButtonDown(0)) 
		{

			box = false;
			GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);

		}
		
	}

	public void OnPointerClick(PointerEventData eventData)
	{

		if (eventData.pointerId == -2) 
		{
			
			GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
			GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = TEXT;
			box = true;

		}

	}
}
