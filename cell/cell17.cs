using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell17 : MonoBehaviour {

	public static int goods17;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods17;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods17 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods17;
		if (transform.childCount == 0)
			goods17 = 0;

	}
}
