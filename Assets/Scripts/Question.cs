using System;


//ovo znaci da ova klasa moze spremat i ucitavat podatke sa diska, omogucuje da iz inspectora mjenjamo svojsvta pitanja, i to fact i isTrue
[Serializable]
//nije unity skripta pa mozemo izbrisati i monobehaviour, start, update i biblioteke
public class Question {

	public string predmet;
	public string fact;
	public string TocanOdgovor, odgovor2, odgovor3, odgovor4;

}
