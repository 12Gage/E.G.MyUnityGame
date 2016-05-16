using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public int Health;

	public float MaxHealth = 100.0f;

	public Texture2D FullHealth, NoHealth;

	void OnTriggerEnter(Collider other){

		if (other.tag.Contains ("Enemy")) {

			Health -= 5;

		}
	}

	void OnGUI(){

		GUI.DrawTexture (new Rect (385, 40, NoHealth.width, NoHealth.height), NoHealth);

		GUI.DrawTexture (new Rect (385, 40, FullHealth.width * (Health/MaxHealth), FullHealth.height), FullHealth);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
