﻿using System.Collections;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {

	public float moveSpeed;
	public float Rotate;
	// Use this for initialization
	void Start ()
  {
		print ("hi");
	moveSpeed = 3f;
	Rotate = 20f;
	}

	// Update is called once per frame
	void Update ()
	{
	transform.Translate(moveSpeed*Input.GetAxis ("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis ("Vertical")*Time.deltaTime);

			float RotateX = Input.GetAxis("Mouse X")*Rotate*Mathf.Deg2Rad;
 	float RotateY = Input.GetAxis("Mouse Y")*Rotate*Mathf.Deg2Rad;

		transform.RotateAround(Vector3.up, -RotateX);
		transform.RotateAround(Vector3.right, -RotateY);

}
	void OnMouseDrag ()
		{
	}
}
