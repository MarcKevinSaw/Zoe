using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell03 : MonoBehaviour {

	// Use this for initialization
	public static int goods03;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods03;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods03 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods03;
		if (transform.childCount == 0)
			goods03 = 0;

	}
}
