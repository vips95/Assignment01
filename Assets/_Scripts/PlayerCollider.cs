using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {
	
	//PUBLIC INSTANCE VARIABLES
	public Text scoreLabel;
	public Text livesLabel;
	public Text gameOverLabel;
	public Text finalScoreLabel;
	public int  scoreValue = 0;
	public int  livesValue = 3;
	
	// PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources; // an array of AudioSources
	private AudioSource _enemyAudioSource, _coinAudioSource, _endAudioSource;
	
	
	// Use this for initialization
	void Start () {
		this._audioSources = this.GetComponents<AudioSource> ();
		this._enemyAudioSource = this._audioSources [1];
		this._coinAudioSource = this._audioSources [2];
		this._endAudioSource = this._audioSources [3];
		
		this._SetScore ();
		this.gameOverLabel.enabled = false;
		this.finalScoreLabel.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D otherGameObject) {
		if (otherGameObject.tag == "Coin") {
			this._coinAudioSource.Play (); // play coin sound
			this.scoreValue += 50; // add 50 points
		}
		if (otherGameObject.tag == "enemy") {
			this._enemyAudioSource.Play (); // play thunder sound
			this.livesValue--; // remove one life
			if(this.livesValue <= 0) {
				this._EndGame();
			}
		}


this._SetScore ();
	}
	

	// PRIVATE METHODS
	private void _SetScore() {
		this.scoreLabel.text = "Score: " + this.scoreValue;
		this.livesLabel.text = "Lives: " + this.livesValue;
	}
	
	private void _EndGame() {

		Destroy(gameObject);
		this.scoreLabel.enabled = false;
		this.livesLabel.enabled = false;
		this.gameOverLabel.enabled = true;
		this.finalScoreLabel.enabled = true;
		this.finalScoreLabel.text = "Score: " + this.scoreValue;
		this._endAudioSource.Play ();
	}

}
