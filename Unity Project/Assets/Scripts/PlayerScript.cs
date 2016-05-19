using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float Health;

	public float Continue = 0.25f;

	public float MaxHealth = 100.0f;

	public Texture2D FullHealth, NoHealth;

	public GUITexture Clover, Moss, Basil, Salt, Flower;

	public GUITexture RocksGUI;

	public Texture2D[] rockTextures;

	public Rigidbody Rock;

	public Transform firePoint;

	public float Force;

	public int Rocks = 5;

	void OnTriggerEnter(Collider other){

		if (other.tag.Contains ("Enemy")) {

			Health -= 5;

		}

		if (Health <= 0) {

			Health = 0;
		}
	}

	void OnTriggerStay(Collider other){

		if (other.tag.Contains ("Enemy")) {

			Health -= Continue;

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

		if (Input.GetButtonDown ("Fire1") && Rocks > 0) {

			Rigidbody tempRock = Instantiate (Rock, firePoint.position, firePoint.rotation)
				as Rigidbody;

			Vector3 fwd = firePoint.TransformDirection (Vector3.forward);

			tempRock.velocity = fwd * Force;

			Rocks --;

			RocksGUI.texture = rockTextures [Rocks];

		}
	}
}
