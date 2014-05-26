using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {


	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name != "prop_powerCube")
		{
			Destroy(col.gameObject);
		}
	}
}
