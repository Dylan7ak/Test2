using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	// Delaring public Variable of the Transform type called ball.
	public Transform ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/* Setting the position of the gameobject this script is
		attached to, to the ImagePosition OffMeshLink the ball. */ 
		transform.position = ball.position;
	}
}
