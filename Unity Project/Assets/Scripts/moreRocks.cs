using UnityEngine;
using System.Collections;

public class moreRocks : MonoBehaviour {

    public string itemName;

    void OnTriggerEnter(Collider other)
    {
        if (itemName == "Rocks" && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Rocks <= 2)
        {

            other.SendMessage("pickupRocks", itemName);

            Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
