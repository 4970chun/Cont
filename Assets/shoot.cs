using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	
	public Rigidbody bulPrefab;
	public Transform barrelEnd;
	private float timer;
	public float wait;
	
	void Update ()
	{
		
		
		
		if(Input.GetButton("Fire1"))
		{
			timer +=Time.deltaTime;
			if(timer >wait){
			Shoot();
				timer=0;
			}
		}
	}
	
	void Shoot()
	{
		Rigidbody bulInstance;
		bulInstance = Instantiate(bulPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
		bulInstance.AddForce(barrelEnd.forward * 5000);
	}

	
}