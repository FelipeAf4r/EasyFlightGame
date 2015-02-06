using UnityEngine;
using System.Collections;

public class TriggerAndAnimation : MonoBehaviour {

	void OnTriggerEnter (Collider c)
	{
		var anim = GetComponentInParent<Animation>();
		anim.Play();
		Destroy(gameObject);
	}
}
