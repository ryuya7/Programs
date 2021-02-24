using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartZoneCreater : MonoBehaviour {

	public GameObject StartZone;

	void Start(){
		StartZone.SetActive(true);
	}

	void startGame(){
		StartZone.SetActive(false);
	}

	void BallFell(){
		StartZone.SetActive(true);
	}

}
