using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//PRESS BANANA 10 TIMES

public class Lvl1 : MonoBehaviour {

	
	public Text Level;
	public Text Prompt;
	public Text Player1;
	public Text Player2;
	public Text Player3;
	public Text Player4;
	


	//Used in Press 10 times
	int count1 = 0;
	int count2 = 0;
	int count3 = 0;
	int count4 = 0;
	//int maxScore;


	public Text presses1;
	public Text presses2;
	public Text presses3;
	public Text presses4;



	public string winner;
	private bool activegame;

	void Start () {
		//in the future we'll clean up lvls, for now it's displaying current minigame
		Level.text = ("Level " + Application.loadedLevel.ToString());
		
		
		//use this to drop in prompts
		Prompt.text = ("Press your banana 10 times!");


		Player1.text = ("Player 1: " + LvlStart.player1Score);
		Player2.text = ("Player 2: " + LvlStart.player2Score);
		Player3.text = ("Player 3: " + LvlStart.player3Score);
		Player4.text = ("Player 4: " + LvlStart.player4Score);

		activegame = true;

	}
	
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Alpha1) && activegame == true)
		{
			count1++;
			presses1.text = count1.ToString();
			if (count1 == 10){
				activegame = false;
			LvlStart.player1Score += 1;
			Player1.text = ("Player 1: " + LvlStart.player1Score);
			
				winner = "Player 1";
				Prompt.text = (winner + " has won... press [space] to go to next lvl.");
			}
		
		}
		
		else if (Input.GetKeyDown(KeyCode.Alpha2) && activegame == true)
		{
			count2++;
			presses2.text = count2.ToString();
			if (count2 == 10){
				activegame = false;
			LvlStart.player2Score += 1;
			Player2.text = ("Player 2: " + LvlStart.player2Score);
			
				winner = "Player 2";
				Prompt.text = (winner + " has won... press [space] to go to next lvl.");
			}


		}
		
		else if (Input.GetKeyDown(KeyCode.Alpha3) && activegame == true)
		{

			count3++;
			presses3.text = count3.ToString();
			if (count3 == 10){
				activegame = false;
			LvlStart.player3Score += 1;
			Player3.text = ("Player 3: " + LvlStart.player3Score);
			
				winner = "Player 3";
				Prompt.text = (winner + " has won... press [space] to go to next lvl.");
			}

		}
		
		else if (Input.GetKeyDown(KeyCode.Alpha4) && activegame == true)
		{

			count4++;
			presses4.text = count4.ToString();
			if (count4 == 10){
				activegame = false;
			LvlStart.player4Score += 1;
			Player4.text = ("Player 4: " + LvlStart.player4Score);
			
				winner = "Player 4";
				Prompt.text = (winner + " has won... press [space] to go to next lvl.");

			}

		}
		
		if (Input.GetKeyDown(KeyCode.Space) && activegame == false )
		{
			Application.LoadLevel(Random.Range(1, Application.levelCount));
		}
		
		
		
		
	}
}
