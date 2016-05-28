using UnityEngine;
using System.Collections;

public class turretScript : MonoBehaviour {

	public Transform target;

	Transform playerPos;

	float playerDistance;

	public float attackDist, lookDistance;

	public Transform firePoint;

	public Rigidbody bullet;

	public float fireRate;

	float fireTime = 0.0f;

	public float bulletForce;

	public int Health;

	public int minHealth, maxHealth;

	void OnTriggerEnter(Collider other){

		if(other.tag.Contains ("Rock")){

			Health--;
			
		}

		if (Health <= 0) {

			Destroy (gameObject);
		}
	}

	void OnGUI(){

		GUI.Label(new Rect (10, 15, 400, 50), "The Distance to the Player is " + playerDistance);
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

		if (playerDistance <= lookDistance) {

			transform.LookAt (target);
		}

		if (playerDistance <= attackDist) {

			if (Time.time > fireTime) {

				Rigidbody tempBullet = Instantiate (bullet, firePoint.position, firePoint.rotation) 
					as Rigidbody;

				Vector3 fwd = firePoint.TransformDirection (Vector3.forward);

				tempBullet.velocity = fwd * bulletForce;

				fireTime = Time.time + fireRate;
			}
		}

	}
}