using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public Transform target;

	Transform playerPos;

	float playerDistance;

	public float enemySpeed = 1.0f;

	public int minHealth, maxHealth;

	public int Health;

	public float attackDist;

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

		target = GameObject.FindWithTag ("Player").transform;

		playerPos = GameObject.FindWithTag ("Player").transform;

		Health = Random.Range (minHealth, maxHealth);
	
	}
	
	// Update is called once per frame
	void Update () {

		playerDistance = Vector3.Distance (transform.position, playerPos.position);

		if (playerDistance <= attackDist) {

			transform.LookAt (target);

			CharacterController controller = GetComponent<CharacterController> ();

			Vector3 forward = transform.TransformDirection (Vector3.forward);

			controller.SimpleMove (forward * enemySpeed);
		}
	}
}
