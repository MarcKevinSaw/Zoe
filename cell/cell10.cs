using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell10 : MonoBehaviour {

	// Use this for initialization
	public static int goods10;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods10;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods10 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods10;
		if (transform.childCount == 0)
			goods10 = 0;
	}
}
