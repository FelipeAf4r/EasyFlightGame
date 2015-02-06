using UnityEngine;
using System.Collections;

[RequireComponent(typeof(前進))]
[RequireComponent(typeof(上下左右))]
[RequireComponent(typeof(Rigidbody))]
public class クラッシュ : MonoBehaviour {

	public GameObject 炎上エフェクト;

	private bool crashed = false;

	/// <summary>
	/// 起動時に呼ばれるコールバック
	/// </summary>
	void Start()
	{
		if( 炎上エフェクト != null)
			炎上エフェクト.SetActive(false);
	}

	/// <summary>
	/// コライダー接触時に呼ばれるコールバック
	/// </summary>
	/// <param name="c">C.</param>
	void OnCollisionEnter (Collision c)
	{
		if( crashed == false){

			//  吹っ飛ばす
			rigidbody.AddExplosionForce(3000, c.contacts[0].point + transform.forward * -1f, 3) ;

			//操作系を停止させる
			GetComponent<Rigidbody>().useGravity = true;
			GetComponent<前進>().enabled = false;
			GetComponent<上下左右>().enabled = false;

			//炎上エフェクトON
			if( 炎上エフェクト != null)
				炎上エフェクト.SetActive(true);
			crashed = true;

			//ゲームオーバーの通知
			GameController.GameOver();
		}
	}

	/// <summary>
	/// 定期的に呼ばれるコールバック
	/// </summary>
	void Update()
	{
		if( 炎上エフェクト != null)
			炎上エフェクト.transform.position = transform.position;
	}
}
