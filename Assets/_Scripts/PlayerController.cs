using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
	public float speed;
	[System.Serializable]
	public class Boundary {
		public float  yMin, yMax;
	}

	public Boundary boundary;



	
	// PRIVATE INSTANCE VARIABLES
	private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this._CheckInput ();
	}
	
	private void _CheckInput() {
		this._newPosition = gameObject.GetComponent<Transform> ().position; // current position
		
		// movement by keyboard
		if (Input.GetAxis ("Vertical") > 0) {
			this._newPosition.y += this.speed; // add move value to current position
		}
	
		
		if (Input.GetAxis ("Vertical") < 0) {
			this._newPosition.y -= this.speed; // subtract move value to current position
		}

		
		// movement by mouse
		/*Vector2 mousePosition = Input.mousePosition;
		this._newPosition.x = this.camera.ScreenToWorldPoint (mousePosition).x;
*/
		this._BoundaryCheck ();
		
		gameObject.GetComponent<Transform>().position = this._newPosition;
	}

	private void _BoundaryCheck() {
		if (this._newPosition.y < this.boundary.yMin) {
			this._newPosition.y = this.boundary.yMin;
		}
		
		if (this._newPosition.y > this.boundary.yMax) {
			this._newPosition.y = this.boundary.yMax;
		}
		}

}
