using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngler : MonoBehaviour {
	public Transform verRot;
	public Transform horRot;
	public float CamSens = 0;

	void Start(){
		verRot = transform.parent;
		horRot = GetComponent<Transform>();
	}

	void Update(){
		float X_Rotation = Input.GetAxis("Mouse X");
		float Y_Rotation = Input.GetAxis("Mouse Y");
		verRot.transform.Rotate(0, X_Rotation*CamSens, 0);
		horRot.transform.Rotate(-Y_Rotation*CamSens, 0, 0);
	}
}
