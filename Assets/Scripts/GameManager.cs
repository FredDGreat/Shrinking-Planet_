using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject gameOverUI;

	public GameObject touchGuide;

	public static bool gameHasStarted = false;

	public static bool pause = false;

	void Awake ()
	{
		instance = this;
		Invoke("DismissTouchGuide", 4);
	}

	public void PauseGame()
    {
		pause = true;

	}

	private void DismissTouchGuide()
	{
		touchGuide.SetActive(false);
	}

	public void ResumeGameAfter(float delay)
    {
		Invoke("Resume", delay);
	}
	private void Resume()
	{
		pause = false;
	}
	public void ActivateGamePlay()
	{
		gameHasStarted = true;
	}

	public void EndGame ()
	{
		pause = true;
		gameOverUI.SetActive(true);
	}

	public void Menu()
	{
		SceneManager.LoadScene("Menu");
	}

	public void RestartWithDelay (float delay)
	{
		Invoke("Restart", delay);
	}

	public void Restart ()
	{
		pause = false;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
