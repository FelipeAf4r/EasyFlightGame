using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
public class 接触時に親のアニメーション再生 : MonoBehaviour 
{
	void Awake()
	{
		collider.isTrigger = true;
	}

	/// <summary>
	/// Triggerと接触した際呼ばれるコールバック
	/// </summary>
	/// <param name="c">C.</param>
	void OnTriggerEnter (Collider c)
	{
		// 親オブジェクトのAnimationを再生し、自殺する
		var anim = GetComponentInParent<Animation>();
		anim.Play();
		Destroy(gameObject);
	}
}
