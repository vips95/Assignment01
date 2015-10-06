using UnityEngine;
using System.Collections;

public class Gamecontroller1 : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public int coinCount;
	public GameObject coin;
	
	// Use this for initialization
	void Start () {
		this._GenerateCoin ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// generate Coin
	private void _GenerateCoin() {
		for (int count=0; count < this.coinCount; count++) {
			Instantiate(coin);
		}
	}
}
