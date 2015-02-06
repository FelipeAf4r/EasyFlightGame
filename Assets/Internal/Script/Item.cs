using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	void OnTriggerEnter (Collider c)
	{
		if( enabled == false ) 
			return;

		ScoreController.AddScore();

		enabled = false;
		Destroy(gameObject);
	}
}
