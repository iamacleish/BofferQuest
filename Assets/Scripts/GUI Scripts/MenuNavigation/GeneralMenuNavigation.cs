﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GeneralMenuNavigation : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void LoadSceneMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void LoadSceneLoadGame(){
		SceneManager.LoadScene ("LoadGame");
	}

	public void LoadSceneNewGame(){
		SceneManager.LoadScene ("NewGame");
	}

	public void LoadSceneSceneSelect(){
		SceneManager.LoadScene ("SceneSelect");
	}

	public void LoadSceneOptions(){
		SceneManager.LoadScene ("Options");
	}

	public void LoadSceneCredits(){
		SceneManager.LoadScene ("Credits");
	}

	public void LoadSceneHighScores(){
		SceneManager.LoadScene ("HighScores");
	}


	/*
	 * 
	 * NEW GAME STUFF
	 * 
	 */
	public void LoadSceneCharacterCreation(int region){
		if (region == 0) {
			region = Random.Range(1, 4);

		}
		PlayerPrefs.SetInt("PlayerRegion", region);
		print (PlayerPrefs.GetInt ("PlayerRegion"));
		SceneManager.LoadScene ("CharacterCreation");
	}
	public void LoadSceneRegionSelect(){
		SceneManager.LoadScene ("RegionSelect");
	}
	//Will be changed to pass in selected stats, save them to a file,
	//and then load the new scene with those stats present.
	public void LoadSceneDayOne(){
		SceneManager.LoadScene ("DayOne");
	}
}
