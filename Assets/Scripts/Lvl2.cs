﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


//HOLD BANANA FOR 5 SECONDS

public class Lvl2 : MonoBehaviour {

	
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


	float timeHeldDown1;
	float timeHeldDown2;
	float timeHeldDown3;
	float timeHeldDown4;

	public string winner;
	private bool activegame;
	
	void Start () {
		//in the future we'll clean up lvls, for now it's displaying current minigame
		Level.text = ("Level " + Application.loadedLevel.ToString());
		
		
		//use this to drop in prompts
		Prompt.text = ("Hold your banana for 5 seconds!");


		Player1.text = ("Player 1: " + LvlStart.player1Score);
		Player2.text = ("Player 2: " + LvlStart.player2Score);
		Player3.text = ("Player 3: " + LvlStart.player3Score);
		Player4.text = ("Player 4: " + LvlStart.player4Score);



		activegame = true;

	}
	
	
	void Update () {

		time1.text = (timeHeldDown1.ToString());
		time2.text = (timeHeldDown2.ToString());
		time3.text = (timeHeldDown3.ToString());
		time4.text = (timeHeldDown4.ToString());
		
		if (Input.GetKey(KeyCode.Alpha1) && activegame == true)
		{
			//Debug.Log("1start");

			timeHeldDown1 += Time.deltaTime;
			//Debug.Log (timeHeldDown1);

			if (timeHeldDown1 > 5f) {
			//	Debug.Log ("ok");
				activegame = false;
				winner = ("Player 1");
				LvlStart.player1Score += 1;
				Player1.text = ("Player 1: " + LvlStart.player1Score);
				Prompt.text = (winner + " is a winner. Press [space] for next level.") ;
			}

		}
		if (Input.GetKeyUp(KeyCode.Alpha1) && activegame == true)
		{
			timeHeldDown1 = 0;
		}


		
		else if (Input.GetKey(KeyCode.Alpha2) && activegame == true)
		{
			//Debug.Log("1start");
			
			timeHeldDown2 += Time.deltaTime;
			//Debug.Log (timeHeldDown1);
			
			if (timeHeldDown2 > 5f) {
				//	Debug.Log ("ok");
				activegame = false;
				winner = ("Player 2");
				LvlStart.player2Score += 1;
				Player2.text = ("Player 2: " + LvlStart.player2Score);
				Prompt.text = (winner + " is a winner. Press [space] for next level.") ;
			}
			
		}
		if (Input.GetKeyUp(KeyCode.Alpha2) && activegame == true)
		{
			timeHeldDown2 = 0;
		}





		else if (Input.GetKey(KeyCode.Alpha3) && activegame == true)
		{
			//Debug.Log("1start");
			
			timeHeldDown3 += Time.deltaTime;
			//Debug.Log (timeHeldDown1);
			
			if (timeHeldDown3 > 5f) {
				//	Debug.Log ("ok");
				activegame = false;
				winner = ("Player 3");
				LvlStart.player3Score += 1;
				Player3.text = ("Player 3: " + LvlStart.player3Score);
				Prompt.text = (winner + " is a winner. Press [space] for next level.") ;
			}
			
		}
		if (Input.GetKeyUp(KeyCode.Alpha3) && activegame == true)
		{
			timeHeldDown3 = 0;
		}



		else if (Input.GetKey(KeyCode.Alpha4) && activegame == true)
		{
			//Debug.Log("1start");
			
			timeHeldDown4 += Time.deltaTime;
			//Debug.Log (timeHeldDown1);
			
			if (timeHeldDown4 > 5f) {
				//	Debug.Log ("ok");
				activegame = false;
				winner = ("Player 4");
				LvlStart.player4Score += 1;
				Player4.text = ("Player 4: " + LvlStart.player4Score);
				Prompt.text = (winner + " is a winner. Press [space] for next level.") ;
			}
			
		}
		if (Input.GetKeyUp(KeyCode.Alpha4) && activegame == true)
		{
			timeHeldDown4 = 0;
		}
		

		if (Input.GetKeyDown(KeyCode.Space)&& activegame == false)
		{
			Application.LoadLevel(Random.Range(1, Application.levelCount));
			Prompt.text = ("sry we have no more lvls");
		}
		
		
		
		
	}
}
