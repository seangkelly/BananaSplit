using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lvl5 : MonoBehaviour {


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

	int[] endCounts;
	
	public Text presses1;
	public Text presses2;
	public Text presses3;
	public Text presses4;
	
	float timeLeft = 5.0f;
	
	public string winner;
	private bool activegame;
	bool existingWinner;


	// Use this for initialization
	void Start () {
		winner = "";

		Level.text = ("Level " + Application.loadedLevel.ToString());
		
		
		//use this to drop in prompts
		Prompt.text = ("Press your key as many times as possible in 5 seconds!");
		
		
		Player1.text = ("Player 1: " + LvlStart.player1Score);
		Player2.text = ("Player 2: " + LvlStart.player2Score);
		Player3.text = ("Player 3: " + LvlStart.player3Score);
		Player4.text = ("Player 4: " + LvlStart.player4Score);
		
		activegame = true;
		existingWinner = false;

		endCounts = new int[4];
	
	}
	
	// Update is called once per frame
	void Update () {
		if(activegame) {
			timeLeft -= Time.deltaTime;
		}

		if (Input.GetKeyDown(KeyCode.Alpha1) && activegame == true)
		{
			count1++;
			presses1.text = count1.ToString();
			
		}
		
		else if (Input.GetKeyDown(KeyCode.Alpha2) && activegame == true)
		{
			count2++;
			presses2.text = count2.ToString();
			
			
		}
		
		else if (Input.GetKeyDown(KeyCode.Alpha3) && activegame == true)
		{
			
			count3++;
			presses3.text = count3.ToString();
			
		}
		
		else if (Input.GetKeyDown(KeyCode.Alpha4) && activegame == true)
		{
			
			count4++;
			presses4.text = count4.ToString();
			
		}

		if ((timeLeft - Time.deltaTime) < 0) {
			activegame = false;
			timeLeft = 0;
			endCounts[0] = count1;
			endCounts[1] = count2;
			endCounts[2] = count3;
			endCounts[3] = count4;
			System.Array.Sort (endCounts);

			if(endCounts[3] == count1){
				winner += "Player 1";	
				LvlStart.player1Score += 1;
				existingWinner = true;
			
			}
			if(endCounts[3] == count2){
				if (existingWinner) {
					winner += " and Player 2";
				}
				else {
					existingWinner = true;
					winner += "Player 2";
				}

				LvlStart.player2Score += 1;
				
			}
			if(endCounts[3] == count3){

				if (existingWinner) {
					winner += " and Player 3";
				}
				else {
					existingWinner = true;
					winner += "Player 3";
				}
				LvlStart.player3Score += 1;
			}
			if(endCounts[3] == count4){
				if (existingWinner) {
					winner += " and Player 4";
				}
				else {
					existingWinner = true;
					winner += "Player 4";
				}
				LvlStart.player4Score += 1;
			}

		}
		
		if (Input.GetKeyDown(KeyCode.Space) && activegame == false )
		{
			Application.LoadLevel(Random.Range(1, Application.levelCount));
		}

	
	}
}
