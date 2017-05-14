using UnityEngine;
using System.Collections;

public class zoe_walk : MonoBehaviour {

	public float move;
	public float speed;
	public bool walk;
	public Animator WALK;


	// Use this for initialization
	void Start () {

		walk = false;
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		move = speed * Input.GetAxis ("Horizontal") * Time.deltaTime;



		if (Input.GetKey (KeyCode.A)||Input.GetKey (KeyCode.D)) 
		{

			walk = true;
			transform.Translate (move, 0, 0);

			if (move > 0) 
			{

				transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);

			}
			else if (move < 0) 
			{

				transform.localScale = new Vector3 (-1.0f, 1.0f, 1.0f);

			}

		}
		else
		{

			walk = false;

		}

		WALK.SetBool ("speed", walk);




	
	}
}
