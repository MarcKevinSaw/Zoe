using UnityEngine;
using System.Collections;

public class zoe_jump : MonoBehaviour {

	public bool ground;
	public GameObject body;
//	public bool jumping;
	public Animator JUMP;
//	public float oldposition;
//	public float newposition;
	// Use this for initialization
	void Start () 
	{

	//	oldposition = body.transform.position.y;
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	/*	newposition = body.transform.position.y;

		if (oldposition < newposition) 
		{

			jumping = true;

		}
		else if(oldposition > newposition)
		{

			jumping = false;

		}

		oldposition = newposition;              */

		if (Input.GetKeyDown (KeyCode.Space) && ground == true) 
		{
			
			body.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 300));

		} 

		JUMP.SetBool ("ground", ground);
	
	}

	void OnTriggerStay2D(Collider2D player)
	{

		if (player.CompareTag  ("Ground")) 
		{

			ground = true;



		}

	}


	void OnTriggerExit2D(Collider2D player)
	{

		ground = false;

	}

}
