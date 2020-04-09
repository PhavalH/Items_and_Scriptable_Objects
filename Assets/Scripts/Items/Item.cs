using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : ScriptableObject {

	public string Name = "New Item";
	public string Description = "New Description";
	public int Price = 0;
	public Type type = Type.Standard;
	public Sprite image;

}

public enum Type {
	Standard, 
	Consumable, 
	Weapon, 
	Armor
}
