using UnityEngine;
using System.Collections;
using UnityEngine.UI;


// DONT PRESS BANANA

public class Lvl3 : MonoBehaviour {

	
	public Text Level;
	public Text Prompt;
	public Text Player1;
	public Text Player2;
	public Text Player3;
	public Text Player4;

	public Text time1;
	public Text time2;
	public Text time3;
	public Text time4;


	private int deathcount;

	private bool active1;
	private bool active2;
	private bool active3;
	private bool active4;


	public string winner;

	private bool activegame;
	
	void Start () {
		//in the future we'll clean up lvls, for now it's displaying current minigame
		Level.text = ("Level " + Application.loadedLevel.ToString());
		
		
		//use this to drop in prompts
		Prompt.text = ("DONT have your banana pressed!");


		Player1.text = ("Player 1: " + LvlStart.player1Score);
		Player2.text = ("Player 2: " + LvlStart.player2Score);
		Player3.text = ("Player 3: " + LvlStart.player3Score);
		Player4.text = ("Player 4: " + LvlStart.player4Score);


		deathcount = 0;

		active1 = true;
		active2 = true;
		active3 = true;
		active4 = true;


		activegame = true;

	}
	
	
	void Update () {


		
		if (Input.GetKeyDown(KeyCode.Alpha1) && activegame == true && active1 == true)
		{
			//Debug.Log("1start");

				active1 = false;
			time1.text = ("loser");
			deathcount +=1;

				//LvlStart.player1Score += 1;
				//Player1.text = ("Player 1: " + LvlStart.player1Score);
				//Prompt.text = (winner + " is a winner. Press [space] for next level.") ;
			}



		
		else if (Input.GetKeyDown(KeyCode.Alpha2) && activegame == true && active2 == true)
		{
			//Debug.Log("1start");
			active2 = false;
			time2.text=("loser");
			deathcount +=1;
			
		}

		else if (Input.GetKeyDown(KeyCode.Alpha3) && activegame == true && active3 == true)
		{
			//Debug.Log("1start");
			active3 = false;
			time3.text=("loser");
			deathcount +=1;
		}

		else if (Input.GetKeyDown(KeyCode.Alpha4) && activegame == true && active4 == true)
		{
			//Debug.Log("1start");
			active4 = false;
			time4.text=("loser");
			deathcount +=1;
		}





		

		if (deathcount == 3)
		{
			activegame = false;

			if (active1 == true)
			{
				winner = "Player 1";
				LvlStart.player1Score += 1;
				Player1.text = ("Player 1: " + LvlStart.player1Score);
				active1 = false;
				Prompt.text = (winner + " is a winner. Press [space] for next level.") ;

			}

			else if (active2 == true)
			{
				winner = "Player 2";
					LvlStart.player2Score += 1;
				Player2.text = ("Player 2: " + LvlStart.player2Score);
				active2 = false;

				Prompt.text = (winner + " is a winner. Press [space] for next level.") ;

			}

			else if (active3 == true)
			{
				winner = "Player 3";
					LvlStart.player3Score += 1;
				Player3.text = ("Player 3: " + LvlStart.player3Score);
				active3 = false;
				Prompt.text = (winner + " is a winner. Press [space] for next level.") ;

			}

			else if (active4 == true)
			{
				winner = "Player 4";
					LvlStart.player4Score += 1;
				Player4.text = ("Player 4: " + LvlStart.player4Score);
				active4 = false;
				Prompt.text = (winner + " is a winner. Press [space] for next level.") ;

			}





		}


		if (Input.GetKeyDown(KeyCode.Space) && activegame == false )
		{
			Application.LoadLevel(Random.Range(1, Application.levelCount));
			Prompt.text =("if youre reading this we are out of lvls sorry");

		}
		
	}
}
