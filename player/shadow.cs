using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadow : MonoBehaviour {

	public GameObject PLAYER;
	public float _X ;
	public float _Y ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		_X = PLAYER.transform.position.x;

		this.transform.position = new Vector3 (_X, _Y, -0.33f);

	}
}
