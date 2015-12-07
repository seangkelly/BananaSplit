using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lvl6 : MonoBehaviour {

	//PRESS X TIMES IN 5 SECONDS


	public Text Level;
	public Text Prompt;
	public Text Player1;
	public Text Player2;
	public Text Player3;
	public Text Player4;

	public Text presses1;
	public Text presses2;
	public Text presses3;
	public Text presses4;

	public float timesToPress;
	float timeLeft = 5.0f;	

	public string winner;
	private bool activegame;
	private bool scoreIncremented;
	bool existingWinner;
	
	//Used in Press 10 times
	int count1 = 0;
	int count2 = 0;
	int count3 = 0;
	int count4 = 0;

	// Use this for initialization
	void Start () 
	{
		winner = "";
		
		Level.text = ("Level " + Application.loadedLevel.ToString());
		
		timesToPress = Random.Range(2,10);
		//use this to drop in prompts
		Prompt.text = ("Press your key" + timesToPress.ToString() + " times in 5 seconds!" + timeLeft.ToString());

		Player1.text = ("Player 1: " + LvlStart.player1Score);
		Player2.text = ("Player 2: " + LvlStart.player2Score);
		Player3.text = ("Player 3: " + LvlStart.player3Score);
		Player4.text = ("Player 4: " + LvlStart.player4Score);
		
		activegame = true;
		existingWinner = false;

	}
	
	// Update is called once per frame
	void Update () 
	{
		Prompt.text = ("Press your key" + timesToPress.ToString() + " times in 5 seconds!" + timeLeft.ToString()) + "\n";
		if (activegame) {
			timeLeft -= Time.deltaTime;
			if(Input.GetKeyDown(KeyCode.Alpha1)) {

				if (count1 < timesToPress) {
					count1++;
					presses1.text = count1.ToString();
				}
				else {
					count1++;
					presses1.text = "LOSER";
				}
			}
			if(Input.GetKeyDown(KeyCode.Alpha2)) {

				if (count2 < timesToPress) {
					count2++;
					presses2.text = count2.ToString();
				}
				else {
					count2++;
					presses2.text = "LOSER";
				}
			}
			if(Input.GetKeyDown(KeyCode.Alpha3)) {

				if (count3 < timesToPress) {
					count3++;
					presses3.text = count3.ToString();
				}
				else {
					count3++;
					presses3.text = "LOSER";
				}
			}
			if(Input.GetKeyDown(KeyCode.Alpha4)) {

				if (count4 < timesToPress) {
					count4++;
					presses4.text = count4.ToString();
				}
				else {
					count4++;
					presses4.text = "LOSER";
				}
				
			}
			if (timeLeft < 0 ) {
				activegame = false;
				timeLeft = 0;
			}


		}
		else {
			if (existingWinner == false) {
				if (count1 == timesToPress) {
					if(existingWinner == false) {
						winner += "Player 1";

					}
					else {
						winner += " and Player 1";

					}
					existingWinner = true;
					LvlStart.player1Score ++;
				}
				if (count2 == timesToPress) {
					if(existingWinner == false) {
						winner += "Player 2";
						
					}
					else {
						winner += " and Player 2";
					}
					existingWinner = true;
					LvlStart.player2Score ++;
				}
				if (count3 == timesToPress) {
					if(existingWinner == false) {
						winner += "Player 3";
						
					}
					else {
						winner += " and Player 3";
					}
					existingWinner = true;
					LvlStart.player3Score ++;
				}
				if (count4 == timesToPress) {
					if(existingWinner == false) {
						winner += "Player 4";
						
					}
					else {
						winner += " and Player 4";
					}
					existingWinner = true;
					LvlStart.player4Score ++;
				}

			}
			if (presses1.text == "LOSER" && presses2.text == "LOSER" && presses3.text == "LOSER" && presses4.text == "LOSER")
			    {
				Prompt.text = ("You all lose, how sad. You're all losers");
			}

			Prompt.text += (winner + " has won... press [space] to go to next lvl.");
			if (Input.GetKeyDown(KeyCode.Space) && activegame == false )
			{
				Application.LoadLevel(Random.Range(1, Application.levelCount));
			}

		}
	}
}
