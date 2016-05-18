using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickUpScript : MonoBehaviour {

	public string itemName;

	public GameObject InventoryHUD;

	void OnTriggerEnter(Collider other){

		if (other.tag == "Player") {

			if (itemName == "Clover") {

				other.SendMessage ("item", itemName);

				Destroy (gameObject);
			}

			if (itemName == "Moss") {

				other.SendMessage ("item", itemName);

				Destroy (gameObject);
			}

			if (itemName == "Basil") {

				other.SendMessage ("item", itemName);

				Destroy (gameObject);
			}

			if (itemName == "Salt") {

				other.SendMessage ("item", itemName);

				Destroy (gameObject);
			}

			if (itemName == "Flower") {

				other.SendMessage ("item", itemName);

				Destroy (gameObject);
			}
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
