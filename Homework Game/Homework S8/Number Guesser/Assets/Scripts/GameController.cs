using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Text displaytext;
	public Button HigherButton;
	public Button LowerButton;
	public Button YesButton;
	int RandomNumber;
	int PickedNumber;
	int ResultNumber = 2;

	// Use this for initialization
	void Start () {
		RandomNumber = Random.Range (0, 100);
		PickedNumber = RandomNumber;
		displaytext.text = "Is " + RandomNumber + " Your Number?";
		NumberRangeChanger ();
	}
	public void higherbutton()
	{
		ResultNumber = 1;
			NumberRangeChanger();
		
	}
	public void lowerbutton()
	{
		ResultNumber = -1;
			NumberRangeChanger();

	}
	public void yesbutton(){
		ResultNumber = 0;
			displaytext.text ="I Got It!";
	}

	public void NumberRangeChanger()
	{
		if (ResultNumber == 1) {
			RandomNumber = Random.Range (PickedNumber, 100);
			PickedNumber = RandomNumber;
			displaytext.text = "Is " + RandomNumber + " Your Number?";
		} else if (ResultNumber == -1) {
			RandomNumber = Random.Range (0, PickedNumber);
			PickedNumber = RandomNumber;
			displaytext.text = "Is " + RandomNumber + " Your Number?";
		} else if (ResultNumber == 0) {
			print ("I Got It!");
			
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
