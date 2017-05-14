using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell24 : MonoBehaviour {

	public static int goods24;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods24;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods24 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods24;
		if (transform.childCount == 0)
			goods24 = 0;

	}
}
