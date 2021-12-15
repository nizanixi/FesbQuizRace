using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	public Text scoreText;
	public static float timeElapsed;
	public GameManager gameManager;

	void Update () {
		
		scoreText.text = timeElapsed.ToString ("0") + " ECTS";

		int y = SceneManager.GetActiveScene().buildIndex;
	
		if (PlayerCollision.timerEnabled && (y!=0)) {
			timeElapsed += Time.deltaTime;
			timeElapsed += Time.deltaTime;

			if (timeElapsed >= 60) {
				Debug.Log ("Great, you have passed this level!");
				Reset ();
				FindObjectOfType<GameManager> ().CompleteLevel();
			}
		}
	}

	public void Reset(){
		timeElapsed = 0;
		GameManagerQuiz.iskoristenJoker = false;
	}
	
}
