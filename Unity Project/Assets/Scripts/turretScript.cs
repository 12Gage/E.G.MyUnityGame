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

    public bool attack;

	void OnTriggerEnter(Collider other){

		if(other.tag.Contains ("Rock")){

			Health--;
			
		}

        if (other.tag.Contains("Rock") && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Hyde == false)
        {

            Health--;

            attack = true;

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

        if (playerDistance <= lookDistance && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Hyde == true)
        {

			transform.LookAt (target);
		}

		if (playerDistance <= attackDist && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Hyde == true) {

			if (Time.time > fireTime) {

				Rigidbody tempBullet = Instantiate (bullet, firePoint.position, firePoint.rotation) 
					as Rigidbody;

				Vector3 fwd = firePoint.TransformDirection (Vector3.up);

				tempBullet.velocity = fwd * bulletForce;

				fireTime = Time.time + fireRate;
			}
		}

        if (attack == true)
        {
            if (playerDistance <= attackDist)
            {
                transform.LookAt(target);

                if (Time.time > fireTime)
                {

                    Rigidbody tempBullet = Instantiate(bullet, firePoint.position, firePoint.rotation)
                        as Rigidbody;

                    Vector3 fwd = firePoint.TransformDirection(Vector3.up);

                    tempBullet.velocity = fwd * bulletForce;

                    fireTime = Time.time + fireRate;
                }
            }
        }

	}
}