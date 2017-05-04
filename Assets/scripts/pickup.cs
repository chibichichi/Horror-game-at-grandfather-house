using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pickup : MonoBehaviour
{
	public GameObject inventoryPanel;
	public GameObject[] inventoryIcons;

	void OnCollisionEnter(Collision collision)
	{
		 //look through children for existing icon
		 foreach(Transform child in inventoryPanel.transform)
		 {
		 	//if item already in inventory
		 	if(child.gameObject.tag == collision.gameObject.tag)
			//helps recongize
		 	{
		 		string c = child.Find("Text").GetComponent<Text>().text;
		 		int tcount = System.Int32.Parse(c) + 1;
	  			child.Find("Text").GetComponent<Text>().text = "" + tcount;
		 		return;
		 	}
		 }



GameObject i;
		 if(collision.gameObject.tag == "rench")
		 {
		 	i = Instantiate(inventoryIcons[0]);
		 	i.transform.SetParent(inventoryPanel.transform);
		 }
		 else if(collision.gameObject.tag == "shovel")
		 {
		 	i = Instantiate(inventoryIcons[1]);
		 	i.transform.SetParent(inventoryPanel.transform);
		 }
		 else if(collision.gameObject.tag == "crowbar")
		 {
		 	i = Instantiate(inventoryIcons[2]);
		 	i.transform.SetParent(inventoryPanel.transform);
		 }

	}

}
