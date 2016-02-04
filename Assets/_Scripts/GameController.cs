// ********************************************
// * Source file : GameController.cs          *
// * Author name : Yaroslav Kabanov           *
// * Last Modified by : Yaroslav Kabanov      *
// * Last Date Modified : February 4th, 2016  *
// * Program Description : Here is side       *
// *   scrolling 2D game where you need to    *
// *   avoid rockets and collect coins to get *
// *   score points. Get as much as you can   *
// *   and survive.                           *
// * Version: 1.0                             *
// ********************************************

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	// private instance variables
	private int _scoreValue;
	private int _livesValue;

	[SerializeField]
	private AudioSource _gameOverSound;

	//public access methods
	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;

			if (this._livesValue <= 0) {
				this._gameOver ();
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}
		}
	}

	//PUBLIC INSTANCE VARIABLES
	public int rocketNumber = 2;
	public RocketController rocket;
	public PlaneController plane;
	public CoinController coin; 
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text ScoreGainedLabel;
	public Button RestartButton;
	public Image gameOverImage;

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
		this.ScoreValue = 0;
		this.LivesValue = 3;
	//	this.GameOverLabel.gameObject.SetActive (false); 
		this.ScoreGainedLabel.gameObject.SetActive (false); 
		this.RestartButton.gameObject.SetActive (false);
		this.gameOverImage.gameObject.SetActive (false);


		for (int rocketCount = 0; rocketCount < this.rocketNumber; rocketCount++) {
			Instantiate (rocket.gameObject);
		}
	}
		private void _gameOver () {
		this.ScoreGainedLabel.gameObject.SetActive (true);
		this.ScoreGainedLabel.text = "Your score : " + this._scoreValue;
	//	this.GameOverLabel.gameObject.SetActive(true);
		this.gameOverImage.gameObject.SetActive (true);
		this.LivesLabel.gameObject.SetActive (false);
		this.ScoreLabel.gameObject.SetActive (false);
		this.plane.gameObject.SetActive (false);
		this.coin.gameObject.SetActive (false);
		this._gameOverSound.Play ();
		this.RestartButton.gameObject.SetActive (true);
	}

	// public methods

	public void RestartButtonClick () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
