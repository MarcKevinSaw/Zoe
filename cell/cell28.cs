using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell28 : MonoBehaviour {

	public static int goods28;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods28;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods28 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods28;
		if (transform.childCount == 0)
			goods28 = 0;

	}
}
