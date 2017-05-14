using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TV : MonoBehaviour {

	public bool click;
	public bool power;
	public Animator tv;
	public static bool back = false;
	public GameObject ani;
	public float timer = 0;
	public bool time_start;
	public float _timer = 0;

	// Use this for initialization
	void Start () {


			
		this.GetComponent<PolygonCollider2D> ().enabled = livingroom_manager.Tv;



	}
	
	// Update is called once per frame
	void Update () 
	{

		livingroom_manager.Tv = this.GetComponent<PolygonCollider2D> ().enabled;

		if (livingroom_manager.Tv == false && back == true) 
		{

			ani.SetActive (false);

		}

		if (time_start == true) 
		{

			timer += Time.deltaTime;

		}

		if (timer >= 0.5f) 
		{

			tv.SetBool ("Power", true);

		}

		if (timer >= 2.5f) 
		{

			back = true;

		}

		if (power == true) 
		{

			this.GetComponent<PolygonCollider2D> ().enabled = false;

			if (Input.GetKeyDown (KeyCode.Escape)) 
			{
				
				time_start = true;

			}

		}

		if (click == true)
		{

			_timer += Time.deltaTime;
			Manager.box = true;

			GameObject.Find ("box").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
			GameObject.Find ("box").transform.GetChild(4).GetComponent<Text>().text = "是否要關掉電視呢?";

			if (Input.GetMouseButtonDown(0) && _timer >= 0.1f && choice.Ans == true) 
			{

				click = false;
				power = true;
				Manager.box = false;

			} 
			else if (Input.GetMouseButtonDown(0) && _timer >= 0.1f && choice.Ans == false) 
			{

				click = false;
				power = false;
				Manager.box = false;

			}

		}
		else if(click == false)
		{

			_timer = 0;
			GameObject.Find ("box").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
			GameObject.Find ("box").transform.GetChild(4).GetComponent<Text>().text = null;

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
