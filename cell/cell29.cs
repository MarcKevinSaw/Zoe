using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell29 : MonoBehaviour {

	public static int goods29;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods29;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods29 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods29;
		if (transform.childCount == 0)
			goods29 = 0;

	}
}
