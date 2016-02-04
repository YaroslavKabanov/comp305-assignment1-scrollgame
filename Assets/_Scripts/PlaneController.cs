using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float speed = 7f;

	// PRIVATE INSTANCE VARIABLES
	private float _playerInput;
	private Transform _transform;
	private Vector2 _currentPosition; 

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {

		this._currentPosition = this._transform.position;  

		this._playerInput = Input.GetAxis ("Vertical"); 
		// check if player input is negative and move down
		if (this._playerInput < 0) {
			this._currentPosition -= new Vector2 (0, this.speed);  

		}
		// check if player input is positive and move up 
		if (this._playerInput > 0) {
			this._currentPosition += new Vector2 (0, this.speed);  
		}

		this._checkBorders ();

		this._transform.position = this._currentPosition;
	}


	// PRIVATE METHODS +++++

	private void _checkBorders () {
		// keep the plain inside the camera view
		if(this._currentPosition.y < -208) {
			this._currentPosition.y = -208;
		}

		if(this._currentPosition.y > 208) {
			this._currentPosition.y =  208;
		}

	}
}
