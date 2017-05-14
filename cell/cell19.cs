using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell19 : MonoBehaviour {

	public static int goods19;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods19;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods19 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods19;
		if (transform.childCount == 0)
			goods19 = 0;

	}
}
