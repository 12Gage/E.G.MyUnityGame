using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

    public string itemName;

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            if (itemName == "Steak")
            {

                other.SendMessage("health", itemName);

                Destroy(gameObject);
            }

            if (itemName == "Chicken")
            {

                other.SendMessage("health", itemName);

                Destroy(gameObject);
            }

            if (itemName == "Apple")
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
