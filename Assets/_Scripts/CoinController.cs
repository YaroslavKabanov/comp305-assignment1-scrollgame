using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
	// PUBLOC INSTANCE VARIABLES
	public float speed = 20f;

	// PRIVATE INSTANCE VARIABLE 
	private Transform _transform;
	private Vector2 _currentPosition;


	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();

		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position; 
		this._currentPosition -= new Vector2 (this.speed, 0);
		this._transform.position = this._currentPosition; 

		if (this._currentPosition.x <= -345) {
			this.Reset ();
		}
	}

	public void Reset ()
	{
		float yPosition = Random.Range (-215f, 215);
		this._transform.position = new Vector2 (345f,yPosition);

	}
}
