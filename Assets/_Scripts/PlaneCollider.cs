using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Coin")) {
			
		}

		if (other.gameObject.CompareTag ("Rocket")) {
			Debug.Log ("lol");
		}
	}
}
