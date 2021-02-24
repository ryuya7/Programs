using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellStatus : MonoBehaviour {

	

	void Update(){
		if(this.tag == "House"){
			GetComponent<MeshRenderer>().material.color = Color.green;
		}
		if(this.tag == "Store"){
			GetComponent<MeshRenderer>().material.color = Color.blue;
		}
	}
}
