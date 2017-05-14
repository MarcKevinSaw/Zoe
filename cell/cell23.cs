using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell23 : MonoBehaviour {

	public static int goods23;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods23;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods23 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods23;
		if (transform.childCount == 0)
			goods23 = 0;

	}
}
