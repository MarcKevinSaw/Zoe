using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell15 : MonoBehaviour {

	public static int goods15;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods15;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods15 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods15;
		if (transform.childCount == 0)
			goods15 = 0;

	}
}
