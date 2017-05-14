using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class photo : MonoBehaviour {

	public bool click;
	public GameObject Photo;
	GameObject P ;
	public float _timer = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{


		if (click == true) {

			_timer += Time.deltaTime;
			Manager.box = true;

			if (bedroom_manager.phone == true) {

				GetComponent<PolygonCollider2D> ().enabled = false;
				GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
				GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "紅色的相框裡面是自己的畢業照，時間過的真快......";

				bag_open.start = false;
				bag_open.blur = true;

				if (Input.GetMouseButtonDown (0) && _timer >= 0.1f) {

					click = false;
					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					Manager.box = false;
					bag_open.blur = false;
					bag_open.timer = 0;
					Destroy (P);
					GetComponent<PolygonCollider2D> ().enabled = true;

				} 

			} else if (bedroom_manager.phone == false) {

				GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 0, 0);
				GameObject.Find ("box02").transform.GetChild (1).GetComponent<Text> ().text = "先打電話吧.......";

				if (Input.GetMouseButtonDown (0) && _timer >= 0.1f) {

					click = false;
					GameObject.Find ("box02").GetComponent<RectTransform> ().rotation = Quaternion.Euler (0, 90, 0);
					Manager.box = false;

				}

			}

		}
		else if (click == false)
			_timer = 0;


	}

	void OnMouseDown()
	{

		if (Manager.dectect == true && Manager.box == false) 
		{
			if (bedroom_manager.phone == true)
			{
				
				P = Instantiate (Photo)as GameObject;
				P.transform.parent = GameObject.Find ("Bag").transform;
				P.GetComponent<RectTransform> ().localPosition = new Vector2 (0, -1950);

			}

			click = true;

		}

	}
}
