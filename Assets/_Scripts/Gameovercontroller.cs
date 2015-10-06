using UnityEngine;
using System.Collections;

public class Gameovercontroller : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// Restart Button Event Handler
	public void OnRestartButtonClick() {
		Application.LoadLevel ("Main");
	}
}
