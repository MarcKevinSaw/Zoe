using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell05 : MonoBehaviour {

	// Use this for initialization
	public static int goods05;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods05;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods05 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods05;
		if (transform.childCount == 0)
			goods05 = 0;

	}
}
