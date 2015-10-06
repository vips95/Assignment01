﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int enemyCount;
	public GameObject enemy;
	
	// Use this for initialization
	void Start () {
		this._GenerateEnemy ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// generate Enemy
	private void _GenerateEnemy() {
		for (int count=0; count < this.enemyCount; count++) {
			Instantiate(enemy);
		}
	}
}
