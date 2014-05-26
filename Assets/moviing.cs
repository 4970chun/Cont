using UnityEngine;
using System.Collections;

public class moviing : MonoBehaviour {

	// Use this for initialization
	public float speed;
	public float h;
	// Update is called once per frame
	void Update(){
		 h = Input.GetAxis("Horizontal");
	}

	void FixedUpdate () {
				rigidbody.AddForce(Vector3.forward*h*speed);
			}
	}

