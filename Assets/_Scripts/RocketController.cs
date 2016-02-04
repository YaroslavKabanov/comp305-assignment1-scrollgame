using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour {
	// PUBLOC INSTANCE VARIABLES
	public float minHorizontalSpeed = 6f;
	public float maxHorizontalSpeed = 10f; 
	public float minVerticalSpeed = -2f;
	public float maxVerticalSpeed = 2f;

	// PRIVATE INSTANCE VARIABLE 
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _horizontalSpeed;
	private float _verticalDrift;


	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();

		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position; 
		this._currentPosition -= new Vector2 (this._horizontalSpeed, this._verticalDrift);
		this._transform.position = this._currentPosition; 

		if (this._currentPosition.x <= -370) {
			this.Reset ();
		}
	}
	// making "new" rockets, reseting existing objects to new random positions
	public void Reset ()
	{
		this._horizontalSpeed = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		this._verticalDrift = Random.Range (this.minVerticalSpeed, this.maxVerticalSpeed);
		float yPosition = Random.Range (-221f, 221);
		this._transform.position = new Vector2 (370f,yPosition);

	} 
}
