using UnityEngine;
using System.Collections;

public class AngelBehaviour : MonoBehaviour {

	public Transform head, body, leftwing, rightwing;
	// Use this for initialization
	void Start () {
			//Anything to initilize?...
	}
	
	// Update is called once per frame
	void Update () {
		//if is moving -> Call the motion function(direction).
	}

	void Motion(Vector3 facingDirection){
		//use force + gravity, then pull head and body back arcording to the facing.
		//Might just move it first, then implement it with delta time later?
	}
}
