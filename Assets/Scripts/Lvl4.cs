using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Lvl4 : MonoBehaviour {
	
	
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

	public Text timerbox;
	
	
	float timeHeldDown1;
	float timeHeldDown2;
	float timeHeldDown3;
	float timeHeldDown4;

	private bool active1;
	private bool active2;
	private bool active3;
	private bool active4;

	float timer = 0.0f;

	string timetracker;
	
	public string winner;
	private bool activegame;
	
	void Start () {
		//in the future we'll clean up lvls, for now it's displaying current minigame
		Level.text = ("Level " + Application.loadedLevel.ToString());
		
		
		//use this to drop in prompts
		Prompt.text = ("Press your key when the timer reaches 5! \nTimer: ");
		
		
		Player1.text = ("Player 1: " + LvlStart.player1Score);
		Player2.text = ("Player 2: " + LvlStart.player2Score);
		Player3.text = ("Player 3: " + LvlStart.player3Score);
		Player4.text = ("Player 4: " + LvlStart.player4Score);
		
		
		
		activegame = true;

		active1 = true;
		active2 = true;
		active3 = true;
		active4 = true;
		
	}
	
	
	void Update () {
		timer += Time.deltaTime;
		timerbox.text = timer.ToString();
/*		time1.text = (timeHeldDown1.ToString());
		time2.text = (timeHeldDown2.ToString());
		time3.text = (timeHeldDown3.ToString());
		time4.text = (timeHeldDown4.ToString());
		*/

		if (Input.GetKeyDown(KeyCode.Alpha1) && activegame == true && timer >= 5 && active1 == true)
		{
	
				activegame = false;
				winner = ("Player 1");
				LvlStart.player1Score += 1;
				Player1.text = ("Player 1: " + LvlStart.player1Score);
				Prompt.text = (winner + " is a winner. Press [space] for next level.") ;
			//timer = Time.deltaTime;
			//timerbox.text = timer.ToString();
			
		}
		if (Input.GetKeyDown(KeyCode.Alpha1) && activegame == true && timer < 5 && active1 == true)
		{
			active1 = false;
			time1.text = ("Loser");
		
		}
		
		
		
		
		if (Input.GetKeyDown(KeyCode.Alpha2) && activegame == true && timer >= 5 && active2 == true)
		{
			
			activegame = false;
			winner = ("Player 2");
			LvlStart.player2Score += 1;
			Player2.text = ("Player 2: " + LvlStart.player2Score);
			Prompt.text = (winner + " is a winner. Press [space] for next level.") ;
			
			
		}
		if (Input.GetKeyDown(KeyCode.Alpha2) && activegame == true && timer < 5 && active2 == true)
		{
			active2 = false;
			time2.text = ("Loser");
			
		}
		
		//3
		
		if (Input.GetKeyDown(KeyCode.Alpha3) && activegame == true && timer >= 5 && active3 == true)
		{
			
			activegame = false;
			winner = ("Player 3");
			LvlStart.player3Score += 1;
			Player3.text = ("Player 3: " + LvlStart.player3Score);
			Prompt.text = (winner + " is a winner. Press [space] for next level.") ;
			
			
		}
		if (Input.GetKeyDown(KeyCode.Alpha3) && activegame == true && timer < 5 && active3 == true)
		{
			active3 = false;
			time3.text = ("Loser");
			
		}


		//4
		if (Input.GetKeyDown(KeyCode.Alpha4) && activegame == true && timer >= 5 && active4 == true)
		{
			
			activegame = false;
			winner = ("Player 4");
			LvlStart.player4Score += 1;
			Player4.text = ("Player 4: " + LvlStart.player4Score);
			Prompt.text = (winner + " is a winner. Press [space] for next level.") ;
			
			
		}
		if (Input.GetKeyDown(KeyCode.Alpha4) && activegame == true && timer < 5 && active4 == true)
		{
			active4 = false;
			time4.text = ("Loser");
			
		}
		
		if (Input.GetKeyDown(KeyCode.Space)&& activegame == false)
		{
			Application.LoadLevel(Random.Range(1, Application.levelCount));
			Prompt.text = ("sry we have no more lvls");
		}
		
		
		
		
	}
}
