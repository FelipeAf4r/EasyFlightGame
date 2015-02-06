using UnityEngine;
using System.Collections;

public class おっかけカメラ : MonoBehaviour {

	public Transform ターゲット;

	private Vector3 firstDiff;

	/// <summary>
	/// 起動時に呼ばれるコールバック
	/// </summary>
	void Start () 
	{
		// カメラとターゲットの差分を事前に取得
		firstDiff = transform.position - ターゲット.position;
	}

	/// <summary>
	/// Updateの後に呼ばれるコールバック
	/// </summary>
	void LateUpdate () 
	{
		// ターゲットの位置をゆるやかに追跡する
		// 但しZ値（距離）だけは固定
		Vector3 pos = transform.position;
		pos.z = ターゲット.position.z + firstDiff.z;
		pos = Vector3.Lerp(pos, ターゲット.position + firstDiff, 0.1f);
		transform.position = pos;
	}
}
