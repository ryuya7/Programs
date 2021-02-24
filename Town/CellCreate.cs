using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellCreate : MonoBehaviour {

	public GameObject CellPrefab;
	public int matX;
	public int matZ;
	public float Interval;

	public int matXcount{
		get{ return this.matX; }
	}
	public int matZcount{
		get{ return this.matZ; }
	}


	void Start () {
		float posX = 0;
		float posZ = 0;
		for(int i=0; i < matX; i++){
			for(int j=0; j < matZ; j++){
				Instantiate(
					this.CellPrefab,
					new Vector3(posX, 0.0f, posZ),
					Quaternion.identity);
				posZ += Interval;
			}
			posZ = 0;
			posX += Interval;
		}
	}
}
