using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterDisplay : MonoBehaviour {

	public Character character;

	public Text name, description, hitpoints;

	void Start(){
		name.text = character.name;
		description.text = character.description + ". " + character.name + " is a " + character.characterClass;
		hitpoints.text = character.hitpoints.ToString();
	}
}
