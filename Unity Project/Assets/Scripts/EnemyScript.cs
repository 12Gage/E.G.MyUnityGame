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

    public bool attack;

	public Animator Walk;

	void OnTriggerEnter(Collider other){

		if(other.tag.Contains ("Rock")){

			Health -= 1;
		}

        if (other.tag.Contains("Rock") && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Hyde == false)
        {

            Health -= 1;

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

        if (playerDistance <= attackDist && GameObject.FindWithTag("Player").GetComponent<PlayerScript>().Hyde == true)
        {
			transform.LookAt (target);

			Walk.SetTrigger ("Walk");

			CharacterController controller = GetComponent<CharacterController> ();

			Vector3 forward = transform.TransformDirection (Vector3.forward);

			controller.SimpleMove (forward * enemySpeed);
		}

        if (attack == true)
        {
            if (playerDistance <= attackDist)
            {
                transform.LookAt(target);

				Walk.SetTrigger ("Walk");

                CharacterController controller = GetComponent<CharacterController>();

                Vector3 forward = transform.TransformDirection(Vector3.forward);

                controller.SimpleMove(forward * enemySpeed);
            }
        }
	}
}
