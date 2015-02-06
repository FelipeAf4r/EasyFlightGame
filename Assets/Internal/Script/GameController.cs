using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

	static GameController Instance;

	[SerializeField]
	private Animator
		gameOver = null, Clear = null;

	private int showTrigger;

	enum GameState
	{
		GameOver,
		GameClear,
		GamePlaying
	}

	private GameState state = GameState.GamePlaying;

	void Awake ()
	{
		Instance = this;

		showTrigger = Animator.StringToHash ("Show");
	}

	public static void GameClear ()
	{
		if (Instance == null || Instance.state != GameState.GamePlaying)
			return;
		Instance.state = GameState.GameClear;
		Instance.Clear.SetTrigger (Instance.showTrigger);
	}

	public static void GameOver ()
	{
		if (Instance == null || Instance.state != GameState.GamePlaying)
			return;
		Instance.state = GameState.GameOver;
		Instance.gameOver.SetTrigger (Instance.showTrigger);
	}

	public void Retry ()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}
