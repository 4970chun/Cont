using UnityEngine;
using System.Collections;

public class Addforcer : MonoBehaviour {

	// Use this for initialization
void OnMouseDown()
	{
		rigidbody.AddForce(-transform.forward*500);
}
}