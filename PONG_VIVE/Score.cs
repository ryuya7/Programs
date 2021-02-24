using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Score : MonoBehaviour {

	public GameObject score_object = null;
	public int score_num1 = 0;
	public int score_num2 = 0;
	public int score_dis = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		score_num1 += 1;
		if(score_num1 < score_num2){
		score_dis = score_num2;
		Text score_text = score_object.GetComponent<Text>();
		score_text.text = "" + score_dis;
		}else{
		score_dis = score_num1;
		Text score_text = score_object.GetComponent<Text>();
		score_text.text = "" + score_dis;
		score_num2 = score_num1;
		}
	}

	void BallFell(){
		score_num1 = 0;
	}

	void startGame(){
		score_num1 = 0;
		Text score_text = score_object.GetComponent<Text>();
		score_text.text = "" + 0;
		score_num2 = score_num1;
	}
}
