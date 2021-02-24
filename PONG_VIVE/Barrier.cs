using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour {

	public static float MAX_ME_X = 2.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		#if UNITY_EDITOR
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (-MAX_ME_X < transform.position.x) {
				transform.Translate (Vector3.left * 0.2f);
			}
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			if (transform.position.x < MAX_ME_X) {
				transform.Translate (Vector3.right * 0.2f);
			}
		}
		return;
		#endif
	}
}
