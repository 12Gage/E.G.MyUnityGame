using UnityEngine;
using System.Collections;

public class gateScript : MonoBehaviour {

    public Animator gate;

    void OnTriggerStay(Collider other)
    {
		if (other.tag == "Player" && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Hyde == true)
        {
            if (Input.GetButton("Fire2"))
            {
                gate.SetTrigger("Open");
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
