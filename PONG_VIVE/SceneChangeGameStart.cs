using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneChangeGameStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("SceneChange", 15.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SceneChange(){
		SceneManager.LoadScene ("Pong");
	}
}