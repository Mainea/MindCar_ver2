﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SportCar_1_Controller_com : NetworkBehaviour {



		
void Start()
	{


	}

	// Update is called once per frame




	void Update()
	{

		if (!isLocalPlayer)
			return;

		if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(new Vector3(0, 0, 2));

		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(new Vector3(0, 0, -2));

		if (Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(new Vector3(0, 2, 0));
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(new Vector3(0, -2, 0));

	}
}
