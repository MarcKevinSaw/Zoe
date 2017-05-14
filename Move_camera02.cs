using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_camera02 : MonoBehaviour {

	public GameObject CAMERA;
	public GameObject CAMERA2;
	public GameObject F_body;
	public Animator f;
	public GameObject Main;
	public GameObject Main2;
	public GameObject PLAYER;
	public GameObject esc;
	public bool In;
	public bool Out;
	public bool all;
	public bool Move;
	public Ray ray;
	public RaycastHit2D hit;

	// Use this for initialization
	void Start () {

		Out = false;
		all = true;

	}

	// Update is called once per frame
	void Update () 
	{
		
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		hit = Physics2D.Raycast (ray.origin, ray.direction, 1000, 512);

		if (Manager.box == false && Manager.magnify == false) 
		{
			

			if (In == true && hit.collider && Input.GetMouseButtonDown(0))
			{

				CAMERA.transform.localScale = new Vector3 (10, 10, 10);
				Main.transform.localScale = new Vector3 (10, 10, 10);
				f.SetBool ("F", false);
				F_body.GetComponent<SpriteRenderer> ().enabled = false;
				PLAYER.SetActive (false);
				Out = true;
				all = false;
				esc.SetActive (true);
				Move = true;
				Manager.dectect = true;

			}

			if (Out == true) 
			{

				if (Input.GetMouseButtonDown (1) || Input.GetKeyDown (KeyCode.Escape)) 
				{

					CAMERA.transform.localScale = new Vector3 (0, 0, 0);
					Main.transform.localScale = new Vector3 (0, 0, 0);
					CAMERA2.transform.localScale = new Vector3 (0, 0, 0);
					Main2.transform.localScale = new Vector3 (0, 0, 0);
					PLAYER.SetActive (true);
					all = true;
					esc.SetActive (false);
					Move = false;
					Manager.dectect = false;

				}

			}

			if (Move == true && Input.GetKeyDown (KeyCode.W))
			{

				CAMERA.transform.localScale = new Vector3 (0, 0, 0);
				Main.transform.localScale = new Vector3 (0, 0, 0);
				CAMERA2.transform.localScale = new Vector3 (10, 10, 10);
				Main2.transform.localScale = new Vector3 (10, 10, 10);

			}
			else if (Move == true && Input.GetKeyDown (KeyCode.S))
			{

				CAMERA2.transform.localScale = new Vector3 (0, 0, 0);
				Main2.transform.localScale = new Vector3 (0, 0, 0);
				CAMERA.transform.localScale = new Vector3 (10, 10, 10);
				Main.transform.localScale = new Vector3 (10, 10, 10);

			}

		}
	}

	void OnTriggerStay2D(Collider2D F)
	{


		if (all == true && F.CompareTag ("Player"))
		{

			f.SetBool ("F", true);
			F_body.GetComponent<SpriteRenderer> ().enabled = true;
			In = true;

		}


	}

	void OnTriggerExit2D(Collider2D player)
	{


		f.SetBool ("F", false);
		In = false;
		F_body.GetComponent<SpriteRenderer> ().enabled = false;

	}

}
