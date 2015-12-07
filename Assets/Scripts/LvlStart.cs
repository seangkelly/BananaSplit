using UnityEngine;
using System.Collections;
using UnityEngine.UI;





public class LvlStart : MonoBehaviour {

	public static int player1Score = 0;
	public static int player2Score = 0;
	public static int player3Score = 0;
	public static int player4Score = 0;


	public Text Level;
	public Text Prompt;
	public Text Player1;
	public Text Player2;
	public Text Player3;
	public Text Player4;

	public string winner;

	private bool activegame;




	void Start () {
		//in the future we'll clean up lvls, for now it's displaying current minigame
		Level.text = ("Level " + Application.loadedLevel.ToString());


		//use this to drop in prompts
		Prompt.text = ("Welcome to the game. \nOne of your hands must be touching the metal magic strip at all times! \n" +
			"Pick a banana, and press [space] to start!");
	

		Player1.text = ("Player 1: " + LvlStart.player1Score);
		Player2.text = ("Player 2: " + LvlStart.player2Score);
		Player3.text = ("Player 3: " + LvlStart.player3Score);
		Player4.text = ("Player 4: " + LvlStart.player4Score);

		activegame = true;
	}
	

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && activegame == true)
		{
			Prompt.text = ("Press your button first!");

		}



		if (Input.GetKeyDown(KeyCode.Alpha1) && activegame == true)
		{
			player1Score += 1;
			Player1.text = ("Player 1: " + player1Score);

			winner = "Player 1";
			Prompt.text = (winner + " has won... press [space] to go to next lvl.");
			activegame = false;

		}

		else if (Input.GetKeyDown(KeyCode.Alpha2) && activegame == true)
		{
			player2Score += 1;
			Player2.text = ("Player 2: " + player2Score);

			winner = "Player 2";
			Prompt.text = (winner + " has won... press [space] to go to next lvl.");
			activegame = false;

		}

		else if (Input.GetKeyDown(KeyCode.Alpha3) && activegame == true)
		{
			player3Score += 1;
			Player3.text = ("Player 3: " + player3Score);


			winner = "Player 3";
			Prompt.text = (winner + " has won... press [space] to go to next lvl.");
			activegame = false;

		}

		else if (Input.GetKeyDown(KeyCode.Alpha4) && activegame == true)
		{
			player4Score += 1;
			Player4.text = ("Player 4: " + player4Score);

			winner = "Player 4";
			Prompt.text = (winner + " has won... press [space] to go to next lvl.");
			activegame = false;


		}

		if (Input.GetKeyDown(KeyCode.Space) && activegame == false)
		{

			//make it random
			Application.LoadLevel(Random.Range(1, Application.levelCount));
		}





	
	}
}
