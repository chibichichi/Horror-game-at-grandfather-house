using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiScript : MonoBehaviour {
	public float fpsTargetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float enemyMovementSpeed;
	public float jumping;
	public Transform fpsTarget;
	Rigidbody theRigidbody;
	Renderer myRender;

	void Start () {
			myRender = GetComponent<Renderer>();
			theRigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		 fpsTargetDistance = Vector3.Distance(fpsTarget.position, transform.position);
		if (fpsTargetDistance < enemyLookDistance) {
			myRender.material.color = Color.yellow;
			lookAtplayer();
			print ("Hello there >D<");
		}
	}

	void lookAtplayer () {
		Quaternion rotation = Quaternion.LookRotation (fpsTarget.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime*jumping);
	}
}
