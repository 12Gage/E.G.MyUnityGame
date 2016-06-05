using UnityEngine;
using System.Collections;

public class moreRocks : MonoBehaviour {

    public Transform[] rockPickup;

    public GameObject rock;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Rocks <= 2)
        {

            int temp = Random.Range(0, rockPickup.Length);

            Instantiate(rock, rockPickup[temp].position,
                        rockPickup[temp].rotation);

        }
	
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            if (other.GetComponent<PlayerScript>().Rocks <= 2)
            {
                other.SendMessage("pickupRocks");

                Destroy(gameObject);

            }
        }
    }
}
