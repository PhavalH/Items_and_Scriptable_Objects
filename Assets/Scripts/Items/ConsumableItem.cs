using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Consumable", menuName = "Inventory Items/Consumable")]
public class ConsumableItem : Item {

	public int hpRestore = 0;
	public int mpRestore = 0;
	public bool removePosion;
}
