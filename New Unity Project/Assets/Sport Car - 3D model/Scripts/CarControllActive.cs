using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllActive : MonoBehaviour {
	var CarControl : GameObject;
	// Use this for initialization
	void Start () {
		CarControl.GetComponent("CarController").endabled = true;
		
	}

}
