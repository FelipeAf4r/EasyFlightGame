using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	[SerializeField]
	UnityEngine.UI.Text scoreLabel;

	private static ScoreController Instance;

	private int hashGetScoreTrigger;
	private int score = 0;

	public void Awake()
	{
		Instance = this;
		hashGetScoreTrigger = Animator.StringToHash("GetScore");
	}

	public static void AddScore()
	{
		if( Instance == null )
			return;

		Instance.score += 1;
		Instance.scoreLabel.text = Instance.score.ToString("0てん");
		Instance.scoreLabel.GetComponent<Animator>().SetTrigger(Instance.hashGetScoreTrigger);
	}
}
