using UnityEngine;
using System.Collections;

public class rockScript : MonoBehaviour {

	public float rockDeath;

	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "Ground") {

			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {

		Destroy (gameObject, rockDeath);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
