using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class 前進 : MonoBehaviour {

	[Range(10, 50)]
	public float スピード = 30;

	/// <summary>
	/// 起動時に呼ばれるコールバック
	/// </summary>
	void Start()
	{
		rigidbody.useGravity = false;
	}

	/// <summary>
	/// 毎フレーム呼ばれるコールバック
	/// </summary>
	void Update () 
	{
		// 前方へ移動する
		transform.position += transform.forward * Time.deltaTime * スピード;
	}
}
