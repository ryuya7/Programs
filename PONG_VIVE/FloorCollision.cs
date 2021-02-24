using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollision : MonoBehaviour {
	public GameObject ScoreManager;
	public GameObject StartZoneCreater;

	private GameObject ballPrefab;
	private GameObject ball;

	void Start(){
		ballPrefab = (GameObject)Resources.Load("Pongs/Ball");
	}

	void startGame(){
		if(ball != null){
			Destroy(ball);
		}

		Vector3 pos = new Vector3(
			transform.position.x,
			transform.position.y - 1.0f,
			transform.position.z + 3.0f);
		ball = (GameObject)Instantiate(ballPrefab, pos, transform.rotation);
		Rigidbody rb = ball.GetComponent<Rigidbody>();
		if(rb != null){
			rb.velocity = new Vector3(
				Random.Range(-4.0f, 4.0f),
				0,
				5.0f);
		}
	}

	void OnCollisionEnter (Collision other)
	{
		ScoreManager.SendMessage ("BallFell");
		StartZoneCreater.SendMessage("BallFell");
		Destroy(ball);
	}
}
