using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	public GameObject respawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider c){
		
		if(c.tag=="enemy"){
			//Destroy(gameObject);
			//LifeCounter
			//GameOverEvent
			//DamageReact
			Respawn();
		}
		
	}
	void Respawn(){
		respawn = GameObject.FindWithTag("Respawn");
		this.transform.position=respawn.transform.position;
	}

}
