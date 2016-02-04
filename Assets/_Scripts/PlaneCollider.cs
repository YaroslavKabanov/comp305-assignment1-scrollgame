using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {
	// private instance variables 
	private AudioSource[] _audioSources;
	private AudioSource _coinSound;
	private AudioSource _rocketSound;


	// Use this for initialization
	void Start () {
		// initialize audio sources array 
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._coinSound = this._audioSources [1];
		this._rocketSound = this._audioSources [2]; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Coin")) {
			this._coinSound.Play ();
		}

		if (other.gameObject.CompareTag ("Rocket")) {
			this._rocketSound.Play ();
		}
	}
}
