using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class 上下左右 : MonoBehaviour {

	public float スピード = 10;

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

		// キー入力を取得
		float y = Input.GetAxis("Vertical");
		float x = Input.GetAxis("Horizontal");

		// 移動値を設定
		Vector3 velocity = rigidbody.velocity;
		velocity.x = x * スピード;
		velocity.y = y * スピード;
		rigidbody.velocity = velocity;

		// キー入力から傾きを設定
		transform.rotation = Quaternion.AngleAxis(x * -30, Vector3.forward);
	}
}
