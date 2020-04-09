using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public Item[] itemArray = new Item[20];
	public List<InventorySlot> inventorySlots = new List<InventorySlot>();

	/**
	 * Add Item
	 * 
	 * @params Item item
	 * 
	 * @return True if item is added to the inventory
	 * 
	 * @return false if inventory is full
	 * 
	 */
	private bool addItemToArray(Item item){
		for(int i = 0; i < itemArray.Length; i++){
			if(itemArray[i] == null){
				itemArray [i] = item;
				inventorySlots [i].item = item;
				return true;
			}
		}
		return false;
	}

	public void addItemToInventory(Item item){
		bool wasAddedToArray = addItemToArray (item);

		if(wasAddedToArray){
			updateInventorySlot ();
		}
	}

	public void updateInventorySlot(){
		for(int i = 0; i < inventorySlots.Count; i++){
			inventorySlots [i].updateSlot();
		}
	}
}
