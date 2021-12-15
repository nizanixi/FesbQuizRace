using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;     // A reference to our PlayerMovement script
	public static int pon = 0;
	private float delay = 1f;
	public static bool timerEnabled = true;

	// This function runs when we hit another object. We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter (Collision collisionInfo) {

		// We check if the object we collided with has a tag called "".
		if (collisionInfo.collider.tag == "Engleski1") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Engleski1";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "IGiP") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "IGiP";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Komunikacijske") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Komunikacijske";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Matematika1") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Matematika1";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "OE1") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "OE1";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "RiP") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "RiP";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Engleski2") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Engleski2";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Programiranje") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Programiranje";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "OE2") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "OE2";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Matematika2") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Matematika2";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Fizika1") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Fizika1";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Ekonomika") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Ekonomika";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Mjerenja") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Mjerenja";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Sklopovi") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Sklopovi";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Engleski3") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Engleski3";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Matematika3") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Matematika3";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Fizika2") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Fizika2";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Digitalna") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Digitalna";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Materijali") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Materijali";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Informacije") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Informacije";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Energetika") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Energetika";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "TeorijaSustava") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "TeorijaSustava";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			}
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Statistika") {

			timerEnabled = false;
			movement.enabled = false;   // Disable the players movement.
			GameManagerQuiz.collisionSubject = "Statistika";

			pon++;

			if (pon == 3) {
				FindObjectOfType<GameManager>().EndGame();
				pon = 0;
			} 
			else if(pon < 3) {
				StartCoroutine (ExecuteAfterDelay());
			}
		}
		if (collisionInfo.collider.tag == "Obstacle") {
			FindObjectOfType<PlayerMovement> ().forwardForce = 10000f;
		}
			
	}

	IEnumerator ExecuteAfterDelay(){
		yield return new WaitForSeconds (delay);
		SceneManager.LoadScene(0);
		timerEnabled = true;
	}
		
}