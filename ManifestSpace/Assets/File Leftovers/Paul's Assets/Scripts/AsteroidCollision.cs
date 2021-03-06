﻿using UnityEngine;
using System.Collections;

public class AsteroidCollision : MonoBehaviour {
	
	// Use this for initialization
	void OnCollisionEnter2D (Collision2D coll) 
	{
		if(coll.gameObject.tag == "Earth" || coll.gameObject.tag == "Planet")
		{
			if(coll.gameObject.GetComponent<Planet>().int_NumberOfHumans > 15)
			{
				coll.gameObject.GetComponent<Planet>().int_NumberOfHumans -= 15;
				GameManager.SharedInstance.HumanCount -= 15;

			}
			else
			{
				GameManager.SharedInstance.HumanCount -= coll.gameObject.GetComponent<Planet>().int_NumberOfHumans;
				coll.gameObject.GetComponent<Planet>().int_NumberOfHumans = 0;
				coll.gameObject.GetComponent<Planet>().planetState = Planet.PlanetState.empty;
			}
			Invoke("Destroy",2.0f);
			GameManager.SharedInstance.CurrentAsteroids.RemoveAt(0);
		}

	}
	void Destroy()
	{
		EventManager.PostEvent(EventManager.eAsteroidDestroyedEvent);
		Destroy(this.gameObject);
	}
}
