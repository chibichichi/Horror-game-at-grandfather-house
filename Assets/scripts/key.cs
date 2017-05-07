using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {

	void Start () {

	}

	void Update ()
	{

	}
void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("player"))
		{

			Destroy(other.gameObject);
		}
	}
}
