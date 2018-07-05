using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		
			if (col.gameObject.tag == "fence")
		{
			transform.Translate(new Vector3(0, 0, -100));
		}
		

	}

	void OnCollisionStay(Collision col)
	{

			if (col.gameObject.tag == "fence")
		{
			transform.Translate(new Vector3(0, 0, -100));
		}

	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "fence")
		{
			transform.Translate(new Vector3(0, 0, -100));
		}
	}
}
