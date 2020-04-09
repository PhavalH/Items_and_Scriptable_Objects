using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Game Objects/Character")]
public class Character : ScriptableObject {

	public string name = "New Character";
	public string description = "New Description";
	public int hitpoints = 100;
	public enum CharacterClass {Fighter, Theif, Mage}
	public CharacterClass characterClass;
}
