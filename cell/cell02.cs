using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cell02 : MonoBehaviour {

	// Use this for initialization
	public static int goods02;
	public int goods;


	// Use this for initialization
	void Start () 
	{
		this.transform.GetComponent<load_goods> ().number = goods02;

	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount == 1)
			goods02 = transform.GetChild (0).GetComponent<number_goods> ().number;
		goods = goods02;
		if (transform.childCount == 0)
			goods02 = 0;

	}
}
