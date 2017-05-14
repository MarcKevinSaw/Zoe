using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell14 : MonoBehaviour {

	// Use this for initialization
	public static int goods14;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods14;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods14 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods14;
		if (transform.childCount == 0)
			goods14 = 0;

	}
}
