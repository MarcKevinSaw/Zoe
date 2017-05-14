using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load_goods : MonoBehaviour {

	public int number;
	public GameObject Charlie;
	public GameObject Princess;
	public GameObject Dairy;
	// Use this for initialization
	void Start () 
	{


		
	}
	
	// Update is called once per frame
	void Update () {

		if (number == 1) 
		{

			GameObject goods = Instantiate (Charlie)as GameObject;
			goods.transform.parent = this.transform;
			goods.transform.position = this.transform.position;
			number = 0;

		}

		if (number == 2) 
		{

			GameObject goods = Instantiate (Princess)as GameObject;
			goods.transform.parent = this.transform;
			goods.transform.position = this.transform.position;
			number = 0;

		}

		if (number == 3) 
		{

			GameObject goods = Instantiate (Dairy)as GameObject;
			goods.transform.parent = this.transform;
			goods.transform.position = this.transform.position;
			number = 0;

		}
	}
}
