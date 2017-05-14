using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class window : MonoBehaviour {

	public bool click;
	public float _timer = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{

		if (click == true)
		{

			_timer += Time.deltaTime;
			GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);

			if (bedroom_manager.phone == false) 
				GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "先打電話吧.......";
			else if(bedroom_manager.phone == true)
				GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "從裡面反鎖的窗戶，外面下著大雷雨。";

			if (Input.GetMouseButtonDown(0) && _timer >= 0.1f) 
			{

				GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
				click = false;
				Manager.box = false;
				_timer = 0;

			}

		} 
			
	}

	void OnMouseDown()
	{

		if (Manager.dectect == true && Manager.box == false) 
		{

			click = true;
			Manager.box = true;

		}

	}
}
