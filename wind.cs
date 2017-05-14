using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour {

	public float windspeed;
	public float windrotato;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(windrotato * Time.deltaTime, 0, 0);
		GetComponent<WindZone> ().windMain = windspeed;
		
	}
}
