using UnityEngine;
using System.Collections;

public class applePickup : MonoBehaviour {

    public Transform[] applepickup;

    public GameObject apple;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Health <= 75
            && GameObject.FindWithTag("Apple") == null)
        {
            int temp = Random.Range(0, applepickup.Length);

            Instantiate(apple, applepickup[temp].position,
                applepickup[temp].rotation);
        }
	}
}
