using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell18 : MonoBehaviour {

	public static int goods18;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods18;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods18 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods18;
		if (transform.childCount == 0)
			goods18 = 0;

	}
}
