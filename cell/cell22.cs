using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell22 : MonoBehaviour {

	public static int goods22;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods22;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods22 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods22;
		if (transform.childCount == 0)
			goods22 = 0;

	}
}
