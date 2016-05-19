using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public float Health = 5;

	void OnControllerColliderHit(ControllerColliderHit other){

		if(other.collider.tag == "Rock"){

			Health--;
		}

		Destroy (other.collider.gameObject);

		if (Health <= 0) {

			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
