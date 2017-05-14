using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CinematicEffects;
using UnityEngine.UI;

public class bag_open : MonoBehaviour {

	public GameObject bag;
	public GameObject CAMERA;
	public static bool start = false;
	public static bool control = false;
	public static bool blur = false;
	public static float timer = 0;

	// Use this for initialization
	void Start () {

		bag.GetComponent<RectTransform> ().localPosition = new Vector2 (0, 2000);
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (control == false) 
		{
			
			if (Input.GetKeyUp (KeyCode.B) && timer == 0) {

				start = true;
				blur = true;
				Manager.magnify = true;

			}

			if (timer >= 0.1f) 
			{

				if (Input.GetKeyUp (KeyCode.B) || Input.GetKeyUp (KeyCode.Escape) || X.closs == true) 
				{

					start = false;
					blur = false;
					timer = 0;
					X.closs = false;
					Manager.magnify = false;
				}

			}

		}

		if (start == true) 
		{

			bag.GetComponent<RectTransform> ().localPosition = new Vector2 (0, 0);
			timer += Time.deltaTime;

		}
		else if (start == false)
		{
			
			bag.GetComponent<RectTransform> ().localPosition = new Vector2 (0, 2000);

		}

		if (blur == true) 
		{

			CAMERA.GetComponent<LensAberrations> ().vignette.enabled = true;
		
		}
		else if (blur == false)
		{

			CAMERA.GetComponent<LensAberrations> ().vignette.enabled = false;
	
		}

	}

}
