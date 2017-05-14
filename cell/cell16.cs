using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell16 : MonoBehaviour {

	public static int goods16;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods16;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods16 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods16;
		if (transform.childCount == 0)
			goods16 = 0;

	}
}
