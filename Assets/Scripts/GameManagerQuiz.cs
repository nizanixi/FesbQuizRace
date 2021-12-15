using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;	//sluzi za postavljanje raznih upita, izmedu ostaloga i prebacivanje iz nizova u liste
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerQuiz : MonoBehaviour {

	//niz question objekata
	public Question[] questions;
	private static List<Question> unanswered = new List<Question>();
	private Question currentQuestion;

	[SerializeField]	//znaci da iako je private, vidljivo je u inspectoru
	private Text questionText;
	[SerializeField]
	private Text answerText;	//Correct ili Wrong
	[SerializeField]
	private GameObject AnswerA;
	[SerializeField]
	private GameObject AnswerB;
	[SerializeField]
	private GameObject AnswerC;
	[SerializeField]
	private GameObject AnswerD;
	[SerializeField]
	private Text Timer;
	private float timeToAnswer = 20.0f;
	private float delayTime = 0;
	private int el;

	public static string collisionSubject;
	public static int levelLoaded = 1;

	public Text ansA;
	public Text ansB;
	public Text ansC;
	public Text ansD;

	public Button bA, bB, bC, bD, b50;

	public static List<string> sveSkupa;
	private List<string> pomocnaLista;

	public static bool iskoristenJoker = false;

	void Start () {

		sveSkupa = new List<string> ();
		pomocnaLista = new List<string> ();
		BuildQuiz ();

		Button btnA = bA.GetComponent<Button>();
		Button btnB = bB.GetComponent<Button>();
		Button btnC = bC.GetComponent<Button>();
		Button btnD = bD.GetComponent<Button>();
		Button half50 = b50.GetComponent<Button> ();

		if (!iskoristenJoker) {
			half50.onClick.AddListener (polaPola);
		}
		btnA.onClick.AddListener(fjA);
		btnB.onClick.AddListener(fjB);
		btnC.onClick.AddListener(fjC);
		btnD.onClick.AddListener(fjD);

		AnswerA.SetActive(true);
		AnswerB.SetActive(true);
		AnswerC.SetActive(true);
		AnswerD.SetActive (true);

		answerText.text = "";	//da bude prazan na pocetku dok jos nema nista u njemu, da ne pise New text

	}
		

	void BuildQuiz(){

		if (unanswered == null || unanswered.Count == 0) {
			unanswered = questions.ToList();
		}
		int id = Random.Range (0, unanswered.Count);	//ide od 0 do broja pitanja, unanswered sadrzi pitanja

		while (unanswered[id].predmet.ToString() != collisionSubject) {
			id = Random.Range (0, unanswered.Count);
		}
			


		currentQuestion = unanswered [id];
		unanswered.RemoveAt (id);

		sveSkupa.Add(currentQuestion.predmet.ToString());
		sveSkupa.Add(currentQuestion.fact.ToString());
		sveSkupa.Add(currentQuestion.TocanOdgovor.ToString());
		sveSkupa.Add(currentQuestion.odgovor2.ToString());
		sveSkupa.Add(currentQuestion.odgovor3.ToString());
		sveSkupa.Add(currentQuestion.odgovor4.ToString());

		for (int i = 0; i < sveSkupa.Count (); i++) {
			if (sveSkupa[i].Contains (collisionSubject)) {
				el = sveSkupa.IndexOf (collisionSubject);	//daje redni broj pitanja te kategorije, pitanje je elemen + 1
			}
		}
			
		questionText.text = sveSkupa [el].ToString () + "\n" + sveSkupa [el + 1].ToString ();

		for (int i = el + 1; i < 6; i++) {
			pomocnaLista.Add (sveSkupa [i].ToString ());
		}

		for (int j = 1; j < pomocnaLista.Count (); j++) {
			string temp = pomocnaLista [j];
			int randInt = Random.Range (j, pomocnaLista.Count ());
			pomocnaLista [j] = pomocnaLista [randInt];
			pomocnaLista [randInt] = temp;
		}

		ansA.text = " A: " + pomocnaLista [1].ToString ();
		ansB.text = " B: " + pomocnaLista [2].ToString ();
		ansC.text = " C: " + pomocnaLista [3].ToString ();
		ansD.text = " D: " + pomocnaLista [4].ToString ();

	}



	public int whichIsCorrect(){
		if (ansA.text == (" A: " + sveSkupa [2].ToString ())) {
			return 1;
		} else if (ansB.text == (" B: " + sveSkupa [2].ToString ())) {
			return 2;
		} else if (ansC.text == (" C: " + sveSkupa [2].ToString ())) {
			return 3;
		} else if (ansD.text == (" D: " + sveSkupa [2].ToString ())) {
			return 4;
		} else
			return 0;
	}

	void polaPola(){

		iskoristenJoker = true;
		int randInt1 = 0;
		int randInt2 = 0;
		int b = whichIsCorrect ();

		do {
			randInt1 = Random.Range (1, 5);
			randInt2 = Random.Range (1, 5);
		} while(randInt1 == randInt2 || randInt1 == b || randInt2 == b);
			
		while (pomocnaLista.Count () == 5 ) {
			if (randInt1 == 1 || randInt2 == 1) {
				AnswerA.SetActive (false);
				pomocnaLista.RemoveAt (1);
			}
			if (randInt1 == 2 || randInt2 == 2) {
				AnswerB.SetActive (false);
				pomocnaLista.RemoveAt (2);
			}
			if (randInt1 == 3 || randInt2 == 3) {
				AnswerC.SetActive (false);
				pomocnaLista.RemoveAt (3);
			}
			if (randInt1 == 4 || randInt2 == 4) {
				AnswerD.SetActive (false);
				pomocnaLista.RemoveAt (4);
			}
		}
		pomocnaLista.Clear ();

	}



	void fjA(){
		if (ansA.text == (" A: " +  sveSkupa[2].ToString() ) ) {
			answerText.text = "Correct!";
			answerText.color = new Color(60f/255f, 142f/255f, 1);	//argumenti su joj RGB komponente od 0-1
			SceneManager.LoadScene(levelLoaded );
		}else {
			answerText.text = "Wrong!";
			answerText.color = new Color(1, 53f/255f, 53f/255f);
		}
		buttonDisable ();
		StartCoroutine (DisplayNextScene ());
	}
	void fjB(){
		if (ansB.text == (" B: " +  sveSkupa[2].ToString()) ) {
			answerText.text = "Correct!";
			answerText.color = new Color(60f/255f, 142f/255f, 1);	//argumenti su joj RGB komponente od 0-1
			SceneManager.LoadScene(levelLoaded );
		}else {
			answerText.text = "Wrong!";
			answerText.color = new Color(1, 53f/255f, 53f/255f);
		}
		buttonDisable ();
		StartCoroutine (DisplayNextScene ());
	}
	void fjC(){
		if (ansC.text == (" C: " +  sveSkupa[2].ToString() ) ) {
			answerText.text = "Correct!";
			answerText.color = new Color(60f/255f, 142f/255f, 1);	//argumenti su joj RGB komponente od 0-1
			SceneManager.LoadScene(levelLoaded );
		}else {
			answerText.text = "Wrong!";
			answerText.color = new Color(1, 53f/255f, 53f/255f);
		}
		buttonDisable ();
		StartCoroutine (DisplayNextScene ());
	}
	void fjD(){
		if (ansD.text == (" D: " +  sveSkupa[2].ToString() ) ) {
			answerText.text = "Correct!";
			answerText.color = new Color(60f/255f, 142f/255f, 1);	//argumenti su joj RGB komponente od 0-1
			SceneManager.LoadScene(levelLoaded );
		}else {
			answerText.text = "Wrong!";
			answerText.color = new Color(1, 53f/255f, 53f/255f);
		}
		buttonDisable ();
		StartCoroutine (DisplayNextScene ());
	}

	void buttonDisable(){
		AnswerA.SetActive(false);
		AnswerB.SetActive(false);
		AnswerC.SetActive(false);
		AnswerD.SetActive (false);
	}

	//korutina koja ceka vrijeme i ponovo ucitava level
	IEnumerator DisplayNextScene(){
		yield return new WaitForSeconds (delayTime);
		GameManager.wrongAnswer = true;
		FindObjectOfType<GameManager>().EndGame();
	}

	void Update () {

		if (AnswerA.activeInHierarchy || AnswerB.activeInHierarchy || AnswerC.activeInHierarchy || AnswerD.activeInHierarchy) {
			Timer.text = timeToAnswer.ToString ("0.0");
			timeToAnswer -= Time.deltaTime;
			if (timeToAnswer <= 0) {
				StartCoroutine (DisplayNextScene ());
			}
		}

	}

}
