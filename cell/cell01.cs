using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell01 : MonoBehaviour {

	// Use this for initialization
	public static int goods01;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods01;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods01 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods01;
		if (transform.childCount == 0)
			goods01 = 0;
	}
}
