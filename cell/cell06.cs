using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell06 : MonoBehaviour {

	// Use this for initialization
	public static int goods06;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods06;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods06 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods06;
		if (transform.childCount == 0)
			goods06 = 0;

	}
}
