using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {

	public Item item;
	public GameObject image;

	public void updateSlot(){
		if (item != null){
			image.GetComponent<Image> ().sprite = item.image;
			image.SetActive(true);
		} else {
			image.SetActive (false);
		}
	}

}
