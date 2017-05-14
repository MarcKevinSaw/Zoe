using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell12 : MonoBehaviour {

	// Use this for initialization
	public static int goods12;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods12;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods12 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods12;
		if (transform.childCount == 0)
			goods12 = 0;
	}
}
