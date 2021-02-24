using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

	public float Speed = 0.5f;
	public float Jamp = 1.0f;
	public float Fall = 0.5f;

	void Update(){
		if(Input.GetKey(KeyCode.W)){
			this.transform.position += transform.forward * Speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.A)){
			this.transform.position -= transform.right * Speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.S)){
			this.transform.position -= transform.forward * Speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.D)){
			this.transform.position += transform.forward * Speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.Space)){
			this.transform.position += transform.up * Jamp * Time.deltaTime;
		}else{
			this.transform.position -= transform.up * Fall * Time.deltaTime;
		}
	}
}
