using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell20 : MonoBehaviour {

	public static int goods20;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods20;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods20 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods20;
		if (transform.childCount == 0)
			goods20 = 0;

	}
}
