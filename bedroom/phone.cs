using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phone : MonoBehaviour {

	public bool click;
	public bool talk;
	public int word = 0;
	public float _timer = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{

		if(click == true)
			_timer += Time.deltaTime;
		if (click == false)
			_timer = 0;

		if (click == true && bedroom_manager.phone == false) {
			
			GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
			GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "電話線被剪斷了......";
			talk = true;

		} 
		else if (click == true && bedroom_manager.phone == true) 
		{

			GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
			GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "話筒裡沒有任何聲音。";
			if (Input.GetMouseButtonDown(0) && _timer >= 0.1f) 
			{

				GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
				click = false;
				Manager.box = false;

			}

		}

		if (Input.GetMouseButtonDown(0) && talk == true && _timer >= 0.1f) 
		{

			_timer = 0;
			word++;

		}

		if (word == 1)
			GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "算了、先看一下有沒有貴重物品被偷了。";
		if (word == 2) 
		{
			
			GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
			bedroom_manager.phone = true;
			talk = false;
			word = 0;
			click = false;
			Manager.box = false;

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
