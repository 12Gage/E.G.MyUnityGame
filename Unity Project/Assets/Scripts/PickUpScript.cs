using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickUpScript : MonoBehaviour {

	public string itemName;

	public GameObject InventoryHUD;

	public Sprite Clover, Moss, Basil, Salt, Flower;

	void OnTriggerEnter(Collider other){

		if (other.tag == "Player") {

			if (itemName == "Clover") {

				InventoryHUD.GetComponent<Image> ().sprite = Clover;

				Destroy (gameObject);
			}

			if (itemName == "Moss") {

				InventoryHUD.GetComponent<Image> ().sprite = Moss;

				Destroy (gameObject);
			}

			if (itemName == "Basil") {

				InventoryHUD.GetComponent<Image> ().sprite = Basil;

				Destroy (gameObject);
			}

			if (itemName == "Salt") {

				InventoryHUD.GetComponent<Image> ().sprite = Salt;

				Destroy (gameObject);
			}

			if (itemName == "Flower") {

				InventoryHUD.GetComponent<Image> ().sprite = Flower;

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
