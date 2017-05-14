using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell09 : MonoBehaviour {

	// Use this for initialization
	public static int goods09;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods09;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods09 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods09;
		if (transform.childCount == 0)
			goods09 = 0;

	}
}
