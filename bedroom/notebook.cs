using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notebook : MonoBehaviour {

	public bool click;
	public int talk = 0;
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
			Manager.box = true;

			if (bedroom_manager.phone == true) 
			{
				
				if (Input.GetMouseButtonDown(0) && _timer >= 0.1f) {

					talk++;
					_timer = 0;

				}

				if (talk == 0) 
				{

					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
					GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "電腦:已經被關機了，你要......";

				}
				if (talk == 1) 
				{

					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					GameObject.Find ("box03").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
					GameObject.Find ("box03").transform.GetChild (0).transform.GetChild (0).GetComponent<Text> ().text = "開機";
					GameObject.Find ("box03").transform.GetChild (1).transform.GetChild (0).GetComponent<Text> ().text = "不動他";

				}
				if (talk == 2 && choice2.Ans2 == true)
				{

					GameObject.Find ("box03").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
					GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "現在不是玩電腦的時候吧......";

				}
				else if (talk == 2 && choice2.Ans2 == false) 
				{

					GameObject.Find ("box03").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					click = false;
					Manager.box = false;
					talk = 0;

				}

				if (talk == 3) 
				{

					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					click = false;
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
