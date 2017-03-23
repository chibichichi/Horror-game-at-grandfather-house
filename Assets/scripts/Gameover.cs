using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour {
	private int playerHealth = 1;
	int damage = 1000;

	void Start () {

		print (playerHealth);
	}

	void Update () {
		if (_collision.gameObject.tag=="Capsule") {
			playerHealth-=damage;
			if (playerHealth<=0){
				print("gameover");
			}
			print ("Your health is " + playerHealth);
		}
	}
}
