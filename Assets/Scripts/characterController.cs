using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

	public float Speed;
	private Vector2 moveVelocity;
	private Rigidbody2D rb;
	Inventory inventory;

	void Awake(){
		inventory = FindObjectOfType<Inventory>();
	}

	void Start(){
		rb = GetComponent<Rigidbody2D> ();
		Speed = 3;

	}

	void Update(){
		Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput.normalized * Speed;
	}

	void FixedUpdate() {
		rb.MovePosition (rb.position + moveVelocity * Time.fixedDeltaTime);
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Touching " + other.name);
		if(other.CompareTag("Pickup")){
			
			inventory.addItemToInventory (other.GetComponent<ItemMB>().item);
			other.gameObject.SetActive(false);
		}
	}
}
