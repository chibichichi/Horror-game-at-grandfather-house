using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {

public bool open = false;

public void openDoor()
		{
		open = !open;
	}

	void Update ()
		{
		if (open)
			{
				Destroy(gameObject);
			}
		}

}
