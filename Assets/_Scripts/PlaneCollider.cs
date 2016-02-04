using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {
	// private instance variables 
	private AudioSource[] _audioSources;
	private AudioSource _coinSound;
	private AudioSource _rocketSound;

	// public instance variables 

	public GameController gameController;


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
		// detect collision with coin object, play sound if happened and add 100 score points
	public void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Coin")) {
			this._coinSound.Play ();
			this.gameController.ScoreValue += 100;
		//	this.gameController.coin.gameObject.SetActive (false);
		}
		// detect collision with rocket object, play rocket sound if happened and deduct 1 live 
		if (other.gameObject.CompareTag ("Rocket")) {
			this._rocketSound.Play ();
			this.gameController.LivesValue -= 1;
		}
	}
}
