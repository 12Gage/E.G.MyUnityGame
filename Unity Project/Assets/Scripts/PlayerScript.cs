using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public int Health;

	public float MaxHealth = 100.0f;

	public Texture2D FullHealth, NoHealth;

	public GUITexture Clover, Moss, Basil, Salt, Flower;

	public GUITexture RocksGUI;

	public Texture2D[] rockTextures;

	public int Rocks = 5;

	public Rigidbody rock;

	public float Force;

	public Transform firePoint;

	void OnTriggerEnter(Collider other){

		if (other.tag.Contains ("Enemy")) {

			Health -= 5;

		}

		if (Health <= 0) {

			Health = 0;
		}
	}

	void OnGUI(){

		GUI.DrawTexture (new Rect (100, 40, NoHealth.width, NoHealth.height), NoHealth);

		GUI.DrawTexture (new Rect (100, 40, FullHealth.width * (Health/MaxHealth), FullHealth.height), FullHealth);

	}

	void item(string itemName)
	{
		if (itemName == "Clover") {

			Clover.enabled = true;

		}else if (itemName == "Moss") {

			Moss.enabled = true;

		}else if (itemName == "Basil") {

			Basil.enabled = true;

		}else if (itemName == "Salt") {

			Salt.enabled = true;

		}else if (itemName == "Flower") {

			Flower.enabled = true;

		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Fire1") && Rocks > 0) {

			Rigidbody tempRock = Instantiate (rock, firePoint.position, firePoint.rotation) as Rigidbody;

			Vector3 fwd = firePoint.TransformDirection (Vector3.forward);

			tempRock.velocity = fwd * Force;

			Rocks -= 1;

			RocksGUI.texture = rockTextures [Rocks];

		}
	}
}
