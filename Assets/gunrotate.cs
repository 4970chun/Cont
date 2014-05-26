using UnityEngine;
using System.Collections;

public class gunrotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		Vector3 targetDir =new Vector3(0,v,h);
		transform.rotation = Quaternion.LookRotation(targetDir);
	}
}
