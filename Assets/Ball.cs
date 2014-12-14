using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// This is a public true or false variable called touching.
	public bool touching;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/* We fire a ray from the center of the ball downwards at a distance 
		 of 0.5f. Then we return the result and store it in the touching variable.*/
		touching = Physics.Raycast( transform.position, Vector3.down, 0.5f );

		// If we are touching the ground, execute code inside brackets.
		if (touching) {

						// If we press the space bar, execute code inside brackets.
						if (Input.GetKeyDown (KeyCode.Space)) {

								/* Set the velocity of the ball to a new Vector3 type of 
				 * coordinate. This instruction only changes the y value of
				 * the ball's velocity. */
								rigidbody.velocity = new Vector3 (rigidbody.velocity.x, 10, rigidbody.velocity.z);
						}
						// if we holding the A Key down, execute code inside brackets.
						if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
								// add torque to the ball in the Z axis.
								rigidbody.AddTorque (Vector3.left * 100);
						}
						// Otherwise, if we holding the D Key down, execute code inside brackets.
						if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
								// add torque to the ball in the Z axis.
								rigidbody.AddTorque (Vector3.right * 100);
						}
						// if we holding the W Key down, execute code inside brackets.
						if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
								// add torque to the ball in the X axis.
								rigidbody.AddTorque (Vector3.forward * 100);
						}
						// Otherwise, if we holding the S Key down, execute code inside brackets.
						if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
								// add torque to the ball in the X axis.
								rigidbody.AddTorque (Vector3.back * 100);
						}
				}

			else {
				}
	}
}
