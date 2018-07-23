using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerCamera_com : NetworkBehaviour {

	public Camera cam;
	// Use this for initialization
	void Start () {
		if (!isLocalPlayer) return;

		cam.enabled = false;
		
	}
	

}
