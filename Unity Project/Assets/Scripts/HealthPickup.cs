using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

    public string itemName;

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            if (itemName == "Steak" && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Health <= 25)
            {

                other.SendMessage("health", itemName);

                Destroy(gameObject);
            }

            if (itemName == "Chicken" && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Health <= 50)
            {

                other.SendMessage("health", itemName);

                Destroy(gameObject);
            }

            if (itemName == "Apple" && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Health <= 75)
            {

                other.SendMessage("health", itemName);

                Destroy(gameObject);
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
