using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Inventory Items/Weapon")]
public class Weapon : Item {

	public int damage = 1;
	public int durablity = 100;
	public string enhancement = "none";
}
