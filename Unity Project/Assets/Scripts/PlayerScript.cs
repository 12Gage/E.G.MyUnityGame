using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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

    public bool clover, moss, salt, basil, flower;

    public string LeveltoLoad, LeveltoLoad2;

	void OnTriggerEnter(Collider other){

		if (other.tag.Contains ("Enemy")) {

			Health -= 5;
		}

		if (other.tag.Contains ("bullet")) {

			Health -= 3;
		}

		if (Health <= 0) {

			Health = 0;

            SceneManager.LoadScene(LeveltoLoad);
		}
	}

	void OnTriggerStay(Collider other){

		if (other.tag.Contains ("Enemy")) {

			Health -= Continue;

		}

		if (Health <= 0) {

			Health = 0;

            SceneManager.LoadScene(LeveltoLoad);
		}
	}

	void OnGUI(){

		GUI.DrawTexture (new Rect (100, 40, NoHealth.width, NoHealth.height), NoHealth);

		GUI.DrawTexture (new Rect (100, 40, FullHealth.width * (Health/MaxHealth), FullHealth.height), FullHealth);

	}

    void health(string itemName)
    {
        if (itemName == "Steak" && Health <= 35)
        {
            Health += 50;
        }
        else if (itemName == "Chicken" && Health <= 50)
        {
            Health += 25;
        }
        else if (itemName == "Apple" && Health <= 75)
        {
            Health += 10;
        }
    }

	void item(string itemName)
	{
		if (itemName == "Clover") {

			Clover.enabled = true;

            clover = true;

		}else if (itemName == "Moss") {

			Moss.enabled = true;

            moss = true;

		}else if (itemName == "Basil") {

			Basil.enabled = true;

            basil = true;

		}else if (itemName == "Salt") {

			Salt.enabled = true;

            salt = true;

		}else if (itemName == "Flower") {

			Flower.enabled = true;

            flower = true;

		}

        if (clover == true && moss == true && basil == true && salt == true && flower == true)
        {
            SceneManager.LoadScene(LeveltoLoad2);
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

    void pickupRocks()
    {
        Rocks++;

        RocksGUI.texture = rockTextures[Rocks];
    }
}
