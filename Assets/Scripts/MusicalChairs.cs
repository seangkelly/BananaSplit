using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicalChairs : MonoBehaviour {

	string[] Alphabet = new string[26] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
	
	int currentStage = 0;

	//Key each player has to press
	string p1;
	string p2;
	string p3;
	string p4;

	//Winner of the round
	string winner;

	//Scoreboard
	int score1;
	int score2;
	int score3;
	int score4;

	//Output text
	Text myTextComponent;
	string textBuffer;

	//Used in Press 10 times
	int count1;
	int count2;
	int count3;
	int count4;
	int maxScore;

	//Used in Hold Key 10 seconds
	float timeHeldDown1;
	float timeHeldDown2;
	float timeHeldDown3;
	float timeHeldDown4;

	float timeCountDown;
	float timeLeft;


	bool gameStart = false;


	// Use this for initialization
	void Start () 
	{
		timeHeldDown1 = 0f;
		timeHeldDown2 = 0f;
		timeHeldDown3 = 0f;
		timeHeldDown4 = 0f;

		timeCountDown = 5f;
	
		myTextComponent = GetComponent<Text>();
		currentStage = 0;

	}
	void startKey ()
	{
		currentStage = 4;
		p1 = Alphabet[Random.Range (0, 25)];
		p2 = Alphabet[Random.Range (0, 25)];
		p3 = Alphabet[Random.Range (0, 25)];
		p4 = Alphabet[Random.Range (0, 25)];

	}
	// Update is called once per frame
	void Update () 
	{
		textBuffer = "";

		//Start Screen
		if (currentStage == 0) {
			myTextComponent = GetComponent<Text>();
			textBuffer = "SCOREBOARD: ";
			textBuffer += "\nPlayer 1: " + score1.ToString();
			textBuffer += "\nPlayer 2: " + score2.ToString();
			textBuffer += "\nPlayer 3: " + score3.ToString();
			textBuffer += "\nPlayer 4: " + score4.ToString();
			textBuffer += "\nPress the [SPACE] key to start!";
			if (Input.GetKeyDown (KeyCode.Space)){
				gameStart = true;
				startKey();
			}
		}

		//Round 1: Press your key first
		if (currentStage == 1) {
			textBuffer = "Press your key before anyone else does!";
			textBuffer += "\nPlayer 1: " + p1;
			textBuffer += "\nPlayer 2: " + p2;
			textBuffer += "\nPlayer 3: " + p3;
			textBuffer += "\nPlayer 4: " + p4;
			if (gameStart) {

				if (Input.GetKeyDown(p1))
				{
					gameStart = false;
					score1++;
					winner = "Player 1";
				}
				if (Input.GetKeyDown(p2))
				{
					gameStart = false;
					score2++;
					winner = "Player 2";

				}
				if (Input.GetKeyDown(p3))
				{
					gameStart = false;
					score3++;
					winner = "Player 3";
				}
				if (Input.GetKeyDown(p4))
				{
					gameStart = false;
					score4++;
					winner = "Player 4";;
				}
			}
			else {
				textBuffer += "\n" + winner + " is the winner!";
				textBuffer += "\nPress [SPACE] to continue.";
				if (Input.GetKeyDown (KeyCode.Space)) {
					currentStage = 0;
				}
			}
		}

		//Round 2: Press your key 10 times
		if (currentStage == 2) {
			textBuffer = "Press your key 10 times!";
			textBuffer += "\nPlayer 1: " + p1 + ", # of presses:" + count1.ToString();
			textBuffer += "\nPlayer 2: " + p2 + ", # of presses:" + count2.ToString();
			textBuffer += "\nPlayer 3: " + p3 + ", # of presses:" + count3.ToString();
			textBuffer += "\nPlayer 4: " + p4 + ", # of presses:" + count4.ToString();

			if (gameStart) {
				if (Input.GetKeyDown(p1)){
					count1++;
					if (count1 == 10)
					{
						gameStart = false;
						score1++;
						winner = "Player 1:"; 
					}
				}
				if (Input.GetKeyDown(p2)){
					count2++;
					if (count2 == 10)
					{
						gameStart = false;
						score2++;
						winner = "Player 2:"; 
					}
				}
				if (Input.GetKeyDown(p3)){
					count3++;
					if (count3 == 10)
					{
						gameStart = false;
						score3++;
						winner = "Player 3:" ;
					}
				}
				if (Input.GetKeyDown(p4)){
					count4++;
					if (count4 == 10)
					{
						gameStart = false;
						score4++;
						winner = "Player 4:"; 
					}
				}
			}
			else {
				textBuffer += "\n" + winner + " is the winner!";
				textBuffer += "\nPress [SPACE] to continue.";
				if (Input.GetKeyDown (KeyCode.Space)) {
					count1 = 0;
					count2 = 0;
					count3 = 0;
					count4 = 0;
					currentStage = 0;
				}
			}
		}

		//Round 3: Press your key for 10 seconds!
		if (currentStage == 3) 
		{
			textBuffer = "Hold Your Key for 5 seconds!";
			textBuffer += "\nPlayer 1: " + p1 + ", Time Held Down:" + timeHeldDown1.ToString();
			textBuffer += "\nPlayer 2: " + p2 + ", Time Held Down:" + timeHeldDown2.ToString();
			textBuffer += "\nPlayer 3: " + p3 + ", Time Held Down:" + timeHeldDown3.ToString();
			textBuffer += "\nPlayer 4: " + p4 + ", Time Held Down:" + timeHeldDown4.ToString();
			if (gameStart){
				if (Input.GetKey(p1)){
					timeHeldDown1 += Time.deltaTime;
					if (timeHeldDown1 > 5f) {
						gameStart = false;
						score1++;
						winner = "Player 1:" ;
					}
				}
				if (Input.GetKeyUp (p1)) {
					timeHeldDown1 = 0f;

				}
				if (Input.GetKey(p2)){
					timeHeldDown2 += Time.deltaTime;
					if (timeHeldDown2 > 5f) {
						gameStart = false;
						score2++;
						winner = "Player 2:" ;
					}

				}
				if (Input.GetKeyUp (p2)) {
					timeHeldDown2 = 0f;
				}
				if (Input.GetKey(p3)){
					timeHeldDown3 += Time.deltaTime;
					if (timeHeldDown3 > 5f) {
						gameStart = false;
						score3++;
						winner = "Player 3:" ;
					}
				}
				if (Input.GetKeyUp (p3)) {
					timeHeldDown3 = 0f;
				}
				if (Input.GetKey(p4)){
					timeHeldDown4 += Time.deltaTime;
					if (timeHeldDown4 > 5f) {
						gameStart = false;
						score4++;
						winner = "Player 4:" ;
					}
				}
				if (Input.GetKeyUp (p4)) {
					timeHeldDown4 = 0f;
				}
			}
			else {
				textBuffer += "\n" + winner + " is the winner!";
				textBuffer += "\nPress [SPACE] to continue.";
				if (Input.GetKeyDown (KeyCode.Space)) {
					timeHeldDown1 = 0f;
					timeHeldDown2 = 0f;
					timeHeldDown3 = 0f;
					timeHeldDown4 = 0f;
					currentStage = 0;
				}
			}
		}

		//Round 4: Press your button as many times as possible
		if (currentStage == 4){
			timeCountDown -= Time.deltaTime;
			textBuffer = "Press your key as many times as possible in 5 second!" + (timeCountDown).ToString();
			textBuffer += "\nPlayer 1: " + p1 + ", # of presses:" + count1.ToString();
			textBuffer += "\nPlayer 2: " + p2 + ", # of presses:" + count2.ToString();
			textBuffer += "\nPlayer 3: " + p3 + ", # of presses:" + count3.ToString();
			textBuffer += "\nPlayer 4: " + p4 + ", # of presses:" + count4.ToString();
			if (gameStart == true){
				if (Input.GetKeyDown(p1)){
					count1++;
				}
				if (Input.GetKeyDown(p2)){
					count2++;
				}
				if (Input.GetKeyDown(p3)){
					count3++;
				}
				if (Input.GetKeyDown(p4)){
					count4++;
				}
				if ((timeCountDown) == 0) {
					gameStart = false;
					maxScore = Mathf.Max (Mathf.Max (Mathf.Max(count1, count2), count3), count4);
					if (count1 == maxScore) {
						winner = "Player 1";
						score1++;
					}
					if (count2 == maxScore) {
						winner = "Player 2";
						score2++;
					}
					if (count3 == maxScore) {
						winner = "Player 3";
						score3++;
					}
					if (count4 == maxScore) {
						winner = "Player 4";
						score4++;
					}
					count1 = 0;
					count2 = 0;
					count3 = 0;
					count4 = 0;
					currentStage = 0;

				}
			}
		} 

		myTextComponent.text = textBuffer;
	}
}