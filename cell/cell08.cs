using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell08 : MonoBehaviour {

	// Use this for initialization
	public static int goods08;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods08;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods08 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods08;
		if (transform.childCount == 0)
			goods08 = 0;

	}
}
