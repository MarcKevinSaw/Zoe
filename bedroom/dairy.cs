using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dairy : MonoBehaviour {

	public bool click;
	public GameObject item;
	public int talk = 0;
	public float _timer = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		this.gameObject.SetActive (bedroom_manager.dairy);


		if (click == true)
		{

			_timer += Time.deltaTime;
			Manager.box = true;

			if (bedroom_manager.phone == true) 
			{
				if (Input.GetMouseButtonDown (0) && _timer >= 0.1f) 
				{
					
					talk++;
					_timer = 0;

				}

				if (talk == 0)
				{
					
					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
					GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "放在櫃子裡的日記本，但要有密碼才能打開......";

				}
				if (talk == 1) 
				{

					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					GameObject.Find ("box").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
					GameObject.Find ("box").transform.GetChild (4).GetComponent<Text> ().text = "要先拿走嗎?";

				}
				if (talk == 2 && choice.Ans == true) 
				{

					click = false;
					GetComponent<PolygonCollider2D> ().enabled = false;
					bedroom_manager.dairy = false;
					GameObject.Find ("box").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					GameObject _item = Instantiate (item)as GameObject;
					_item.transform.parent = GameObject.Find ("Canvas").transform;
					Manager.box = false;
					talk = 0;

				}
				else if (talk == 2 && choice.Ans == false)
				{

					click = false;
					GameObject.Find ("box").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					Manager.box = false;
					talk = 0;

				}

			} 
			else if (bedroom_manager.phone == false)
			{

				GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
				GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "先打電話吧.......";

				if (Input.GetMouseButtonDown(0) && _timer >= 0.1f) 
				{

					click = false;
					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					Manager.box = false;
					_timer = 0;

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
