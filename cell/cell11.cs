using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell11 : MonoBehaviour {

	// Use this for initialization
	public static int goods11;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods11;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods11 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods11;
		if (transform.childCount == 0)
			goods11 = 0;

	}
}
