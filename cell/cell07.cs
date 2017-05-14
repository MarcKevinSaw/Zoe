using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell07 : MonoBehaviour {

	// Use this for initialization
	public static int goods07;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods07;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods07 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods07;
		if (transform.childCount == 0)
			goods07 = 0;

	}
}
