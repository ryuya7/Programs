using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartZone : MonoBehaviour {

	public GameObject RestartZone;
	public GameObject ScoreManager;
	public GameObject StartZoneCreater;

	void Start(){
		//Instantiate(RestartZone);
		//Instantiate(ScoreManager);
		//Instantiate(StartZoneCreater);
	}

	void OnTriggerEnter(Collider other){
		RestartZone.SendMessage("startGame");
		ScoreManager.SendMessage("startGame");
		StartZoneCreater.SendMessage("startGame");
	}
}
