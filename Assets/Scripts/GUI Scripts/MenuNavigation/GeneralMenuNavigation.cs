using UnityEngine;
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

}
