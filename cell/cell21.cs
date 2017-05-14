using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell21 : MonoBehaviour {

	public static int goods21;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods21;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods21 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods21;
		if (transform.childCount == 0)
			goods21 = 0;

	}
}
