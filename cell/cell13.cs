using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell13 : MonoBehaviour {

	// Use this for initialization
	public static int goods13;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods13;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods13 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods13;
		if (transform.childCount == 0)
			goods13 = 0;

	}
}
