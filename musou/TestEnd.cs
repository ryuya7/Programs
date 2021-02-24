using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestEnd : MonoBehaviour {
	private void OnTriggerEnter(Collider other){
		SceneManager.LoadScene("Game");
	}
}
