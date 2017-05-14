using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell25 : MonoBehaviour {

	public static int goods25;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods25;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods25 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods25;
		if (transform.childCount == 0)
			goods25 = 0;

	}
}
