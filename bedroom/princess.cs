﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class princess : MonoBehaviour {

	public bool click;
	public GameObject item;
	public float _timer = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		this.gameObject.SetActive (bedroom_manager.princess);


		if (click == true) 
		{

			Manager.box = true;
			_timer += Time.deltaTime;

			if (bedroom_manager.phone == true) 
			{

				GameObject.Find ("box").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
				GameObject.Find ("box").transform.GetChild (4).GetComponent<Text> ().text = "一本叫做《小公主的一天》的童話書，名字真是奇怪。要帶走他嗎?";

				if (Input.GetMouseButtonDown(0) && choice.Ans == true && _timer >= 0.1f) 
				{

					_timer = 0;
					click = false;
					GetComponent<PolygonCollider2D> ().enabled = false;
					bedroom_manager.princess = false;
					GameObject.Find ("box").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					GameObject _item = Instantiate (item)as GameObject;
					_item.transform.parent = GameObject.Find ("Canvas").transform;
					Manager.box = false;

				} 
				else if (Input.GetMouseButtonDown(0) && choice.Ans == false && _timer >= 0.1f) 
				{

					_timer = 0;
					click = false;
					GameObject.Find ("box").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					Manager.box = false;

				}

			}
			else if (bedroom_manager.phone == false)
			{

				GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
				GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "先打電話吧.......";

				if (Input.GetMouseButtonDown(0) && _timer >= 0.1f) 
				{

					_timer = 0;
					click = false;
					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					Manager.box = false;

				}

			}

		}
			

	}

	void OnMouseDown()
	{

		if (Manager.dectect == true && Manager.box == false) 
		{

			click = true;

		}

	}
}
