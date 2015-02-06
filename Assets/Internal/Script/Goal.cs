using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	[ContextMenu("clear")]
	void OnTriggerEnter (Collider c)
	{
		GameController.GameClear();
	}
}
