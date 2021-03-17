using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
using System.Linq;
public class PilipinasManager : MonoBehaviour {
	
	//variable
	public Questions[] question;

	private static List<Questions> unanswer;

	private Questions current;

	[SerializeField]
	private Text trueText;


	[SerializeField]
	private Text FalseText;

	[SerializeField]
	private float timeBetweenQUestion = 1f;

	public static int gm;

	private int score = 5;

	private GameObject a;

	[SerializeField]
	private Text scoretext;

	[SerializeField]
	private Text HintTEXT;

	[SerializeField]
	private Text helptext;

	private int index;


	void Start () {

		if (unanswer == null || unanswer.Count == 0) 
		{
			unanswer = question.ToList<Questions> ();
		}
		SetCurrentQuestion ();	

	}
	//questiion code
	void SetCurrentQuestion () {
		int randomquestion = Random.Range (0, unanswer.Count);
		current = unanswer [randomquestion];
	}

	IEnumerator TransitionToNextQuestion()
	{
		unanswer.Remove (current);

		yield return new WaitForSeconds (timeBetweenQUestion);

		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

	}
	//correct answer code
	public void UserSelectTrue()
	{
			score = score + 0;
			scoretext.text = score.ToString ();
			ScoreManager.AddCoins (score);
			trueText.text = "";
			HintTEXT.text = "";
			helptext.text	="";
	}

	//correct answer code
	public void UserSelectTrue1()
	{
		SceneManager.LoadScene ( PlayerPrefs.GetInt("Level") );
		trueText.text = "";
		HintTEXT.text = "";
		helptext.text	="";
	}
	//correct answer message code
	public void MessageCorrect()
	{
		
			Debug.Log ("TAMA");
			trueText.text = "MAGALING TAMA ANG IYONG SAGOT";
			FalseText.text = "";
			HintTEXT.text = "";
			helptext.text	="";

	}

	//correct answer message code
	public void MessageFalse()
	{

		Debug.Log ("MAli");
		FalseText.text = "MALI ANG IYONG SAGOT";
		trueText.text = "";
		HintTEXT.text = "";
		helptext.text	="";
	}
	//wrong answer code
	public void UserSelectFalse()
	{
		HealthControlScript.health -= 1;
		PlayerPrefs.SetInt ("health", HealthControlScript.health);
		FalseText.text = "";
		PlayerPrefs.SetInt ("Level", SceneManager.GetActiveScene ().buildIndex);
		HintTEXT.text = "";
		helptext.text	="";
		if(HealthControlScript.health==0){
			Debug.Log ("Back");
			FalseText.text = "";
			SceneManager.LoadScene ("Reserve");
			HealthControlScript.health = 3;
		}

	}
	//wrong answer code
	public void UserSelectFalse1()
	{
		
		FalseText.text = "";

		HintTEXT.text = "";
		helptext.text	="";

	}
	//end level code
	public void REWARD(int levelnext){
		PlayerPrefs.SetInt("levelReached", levelnext);

	}
	//end level code
	public void t5(){
		score = score+25;
		scoretext.text = score.ToString ();
		ScoreManager.AddCoins (score);
	}

	//reveal code
	public void Reveal(){

		if (ScoreManager.Score < 20) {
			helptext.text	="Your coins is not enough!";
		} else {
			//pilipinas
			if (GameObject.Find ("Pilipinas1")) {
				HintTEXT.text = "Balloons";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Pilipinas2")) {
				HintTEXT.text = "These are foods that represents a country ";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Pilipinas3")) {
				HintTEXT.text = "Bonus, no hint";
			
			}
			else if (GameObject.Find ("Pilipinas2")) {
				HintTEXT.text = "These are foods that represents a country ";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Pilipinas4")) {
				HintTEXT.text = "Sometimes a Man, sometimes Fish";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Pilipinas5")) {
				HintTEXT.text = "Tagalog of Stage Play";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Pilipinas6")) {
				HintTEXT.text = "Think of Popes and Saints";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Pilipinas7")) {
				HintTEXT.text = "Head of an Elementary or Secondary School";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Pilipinas8")) {
				HintTEXT.text = "Ginebra";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Pilipinas9")) {
				HintTEXT.text = "Exchange Gifts";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Pilipinas10")) {
				HintTEXT.text = "F.D";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			//spain
			else if (GameObject.Find ("Span1")) {
				HintTEXT.text = "Atapang A-Tao";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Span2")) {
				HintTEXT.text = "He’s our National Hero";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Span3")) {
				HintTEXT.text = "Again, Sometimes a Man, sometimes Fish";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Span4")) {
				HintTEXT.text = "Is He a King TOO?";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Span5")) {
				HintTEXT.text = "GORYO";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Span6")) {
				HintTEXT.text = "PEPE";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Span7")) {
				HintTEXT.text = "PRIESTS";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Span8")) {
				HintTEXT.text = "C – B";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Span9")) {
				HintTEXT.text = "His Surname Sounds like a Facial Wash Foam.";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Span10")) {
				HintTEXT.text = "B-M";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			//american
			else if (GameObject.Find ("American1")) {
				HintTEXT.text = "AVENUE";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Ameican2")) {
				HintTEXT.text = "If You’re Old and Retired, You can get it from SSS";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Ameican3")) {
				HintTEXT.text = "Duterte Ordered to Clean It Up";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Ameican4")) {
				HintTEXT.text = "981206";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Ameican5")) {
				HintTEXT.text = "Christmas Present";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Ameican6")) {
				HintTEXT.text = "Eifel Tower";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Ameican7")) {
				HintTEXT.text = "Tonshingwa";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Ameican8")) {
				HintTEXT.text = "(Bonus, no hint)";
				
			}
			else if (GameObject.Find ("Ameican9")) {
				HintTEXT.text = "Region IV";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("Ameican10")) {
				HintTEXT.text = "Last Name Sounds like his First Name";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			
			//japanese
			else if (GameObject.Find ("J1")) {
				HintTEXT.text = "An Avenger";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("J2")) {
				HintTEXT.text = "LT";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("J3")) {
				HintTEXT.text = "March to the Death";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("J4")) {
				HintTEXT.text = "KLBP";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("J5")) {
				HintTEXT.text = "BLOOD";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("J6")) {
				HintTEXT.text = "CHOOSE";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("J7")) {
				HintTEXT.text = "(bonus, no hint)";
			}
			else if (GameObject.Find ("J8")) {
				HintTEXT.text = "(bonus, no hint)";
				
			}
			else if (GameObject.Find ("J9")) {
				HintTEXT.text = "(bonus, no hint)";
			
			}
			else if (GameObject.Find ("J10")) {
				HintTEXT.text = "(bonus, no hint)";
			
			}
			//level5
			else if (GameObject.Find ("L1")) {
				HintTEXT.text = "Say times two";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("L2")) {
				HintTEXT.text = "November";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("L3")) {
				HintTEXT.text = "Dictator";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("L4")) {
				HintTEXT.text = "Capital";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("L5")) {
				HintTEXT.text = "It is our time";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("L6")) {
				HintTEXT.text = "Adding Binary :True = 0 ,False = 1 ( 1+1 = ?)";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("L7")) {
				HintTEXT.text = "Sound like a Rooster";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("L8")) {
				HintTEXT.text = "Moscow";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
				
			}
			else if (GameObject.Find ("L9")) {
				HintTEXT.text = "Not by land.";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			
			}
			else if (GameObject.Find ("L10")) {
				HintTEXT.text = "I am a LIAR, the answer is not letter C";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			
			}
			//reserve
			else if (GameObject.Find ("R1")) {
				HintTEXT.text = "Hiroshima Sea";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("R2")) {
				HintTEXT.text = "Noli & El Fili";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("R3")) {
				HintTEXT.text = "Bruce Lee, Jet Li, Jackie Chan";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("R4")) {
				HintTEXT.text = "Bye";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("R5")) {
				HintTEXT.text = "Sounds like LION";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("R6")) {
				HintTEXT.text = "Nani ?!";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			else if (GameObject.Find ("R7")) {
				HintTEXT.text = "Adaptor";
				helptext.text	="Clue Reaveal";
				ScoreManager.Score  =ScoreManager.Score -20;
				scoretext.text = score.ToString ();
				ScoreManager.AddCoins (score);
			}
			
		}
	}

	//reset code
	public void reset(){
		
		PlayerPrefs.DeleteAll();
		ScoreManager.Score =0;
		SceneManager.LoadScene ("Menu");
	}

}
