using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurncountTrigger_com : MonoBehaviour {
	
	public GameObject HalfLapTrig;
	public GameObject TurncountTrig;
	void OnTriggerEnter()
	{
		TurncountTrig.SetActive(false);
		TurnManager.Turncount++;

		HalfLapTrig.SetActive(true);

	
	}
}
