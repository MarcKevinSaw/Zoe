using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell30 : MonoBehaviour {

	public static int goods30;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods30;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods30 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods30;
		if (transform.childCount == 0)
			goods30 = 0;

	}
}
