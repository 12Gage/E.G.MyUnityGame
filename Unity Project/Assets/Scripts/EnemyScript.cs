using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public float Health = 5;

	void OnTriggerEnter(Collider other){

		if(other.tag.Contains ("Rock")){

			Health -= 1;
		}
			
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
