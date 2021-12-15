using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public bool gameHasEnded = false;
	public static bool wrongAnswer = false;
	public GameObject completeLevelUI;

	public void CompleteLevel (){
		completeLevelUI.SetActive(true);
	}

	public void EndGame (){
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("GAME OVER");
			StartCoroutine (ExecuteAfterDelay ());
		} else if (wrongAnswer) {
			gameHasEnded = true;
			Debug.Log ("WRONG ANSWER! GAME OVER");
			StartCoroutine (ExecuteAfterDelay ());
		}
	}

	IEnumerator ExecuteAfterDelay(){
		yield return new WaitForSeconds (2f);
		FindObjectOfType<Score>().Reset();
		SceneManager.LoadScene(1);
	}

}
