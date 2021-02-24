using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour {

	public GameObject ScoreManager;
	public AudioClip Bound;
	private AudioSource BoundSound;

	void Start(){
		BoundSound = GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision col){
		Rigidbody rb = null;
		if (col.gameObject.name == "Barrier"){
			rb = GetComponent<Rigidbody> ();
		}
		if (rb != null){
			if(Random.Range(0, 4) == 0){
				rb.velocity = new Vector3 (
					Random.Range (-4.0f, 4.0f), 0, rb.velocity.z + 0.5f);
			}else{
				rb.velocity = new Vector3 (
					rb.velocity.x + Random.Range (-4.0f, 4.0f), 0, rb.velocity.z + 0.5f);
			}
		}
		BoundSound.PlayOneShot(Bound);
	}
}