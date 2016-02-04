using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// private instance variables
	private int _scoreValue;
	private int _livesValue;

	//public access methods
	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			Debug.Log (this._scoreValue);
		}
	}

	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;
			Debug.Log (this._livesValue);
		}
	}

	//PUBLIC INSTANCE VARIABLES
	public int rocketNumber = 2;
	public RocketController rocket;

	// Use this for initialization
	void Start () {
		this._initialize ();
		this.ScoreValue = 0;
		this.LivesValue = 3;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Private methods +++++


	// Initial methods
	private void _initialize() {
		for (int rocketCount = 0; rocketCount < this.rocketNumber; rocketCount++) {
			Instantiate (rocket.gameObject);
		}
	}
}