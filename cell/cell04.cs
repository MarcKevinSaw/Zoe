using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell04 : MonoBehaviour {

	// Use this for initialization
	public static int goods04;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods04;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods04 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods04;
		if (transform.childCount == 0)
			goods04 = 0;

	}
}
