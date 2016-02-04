using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//PUBLIC INSTANCE VARIABLES
	public int rocketNumber = 2;
	public RocketController rocket;

	// Use this for initialization
	void Start () {
		this._initialize ();
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