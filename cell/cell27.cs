using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell27 : MonoBehaviour {

	public static int goods27;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods27;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods27 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods27;
		if (transform.childCount == 0)
			goods27 = 0;

	}
}
