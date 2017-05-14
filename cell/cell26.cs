using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell26 : MonoBehaviour {

	public static int goods26;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods26;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods26 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods26;
		if (transform.childCount == 0)
			goods26 = 0;

	}
}
