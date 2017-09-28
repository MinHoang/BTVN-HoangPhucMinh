using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneScript : MonoBehaviour {

	public Text levelText;
	public InputField inputField;
	public Button submitButton;
	public Text hintText;
	public Button NextLevelButton;

	public string levelContent = "LEVELS";
	public string levelNumber;
	public string levelAnswer;
	string answer;

	// Use this for initialization
	void Start () {
		NextLevelButton.gameObject.SetActive (false);
		levelText.text = levelContent;
		StartCoroutine (ChangeLevelTextRoutine());


	}
	public void nextLevelbutton(){
		SceneManager.LoadScene("Level"+" "+ (int.Parse(levelNumber) + 1));
		NextLevelButton.gameObject.SetActive (false);
		
	}
	public void GetInput(){
		answer = inputField.text;
		CheckAnswer ();

	}
	public void CheckAnswer(){
		if (answer == levelAnswer) {
			hintText.color = Color.black;
			hintText.text = "Correct";
			NextLevelButton.gameObject.SetActive (true);
		} else {
			hintText.text ="Incorrect";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}
	}

	IEnumerator ChangeLevelTextRoutine(){
		while (true) {
			levelText.text = levelContent;
			yield return new WaitForSeconds (2f);
			levelText.text = levelNumber;
			yield return new WaitForSeconds (2f);


		}
	}
	public void startscene() {
		SceneManager.LoadScene ("Level 1");
	}
	

}
