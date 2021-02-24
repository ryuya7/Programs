using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRay : MonoBehaviour {

	public Camera maincamera;
	public float distance;
	public GameObject StatusManager;

	void Start () {
		
	}
	
	void LateUpdate () {
		Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		Debug.DrawRay(ray.origin, ray.direction * distance, Color.green, 0.0f);
		if(Physics.Raycast(ray, out hit, distance)){
			if(Input.GetKeyDown(KeyCode.Alpha1)){
				if(hit.collider.tag != "House"){
					hit.collider.tag = "House";
					StatusManager.GetComponent<StatusManager>().Population += 50;
					StatusManager.GetComponent<StatusManager>().Money -= 50;
				}
			}
			if(Input.GetKeyDown(KeyCode.Alpha2)){
				if(hit.collider.tag == "House"){
					StatusManager.GetComponent<StatusManager>().Population -= 50;
				}
				if(hit.collider.tag != "Store"){
					hit.collider.tag = "Store";
					StatusManager.GetComponent<StatusManager>().Money += 100;
				}
			}
			if(Input.GetKeyDown(KeyCode.Alpha0)){
				if(hit.collider.tag == "House"){
					StatusManager.GetComponent<StatusManager>().Population -= 50;
				}
				if(hit.collider.tag != "None"){
					hit.collider.tag = "None";
				}
			}
			Debug.Log(hit.collider.tag);
			hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
		}
	}
}
