using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour {

	public int Population;
	public int Money;
	public GameObject PopObject;
	public GameObject MonObject;

	void Update(){
		WriteText(Population, Money);
	}

	public void WriteText(int Pop, int Mon){
		Text PopText = PopObject.GetComponent<Text>();
		PopText.text = "Population : " + Population;
		Text MonText = MonObject.GetComponent<Text>();
		MonText.text = "Money : " + Money;
	}
}
