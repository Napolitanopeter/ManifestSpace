using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class startGame : MonoBehaviour {

	public Text planetText;

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetInt("Planets", 10);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Game()
	{
		Application.LoadLevel(1);
	}

	public void Planets10()
	{
		PlayerPrefs.SetInt("Planets", 10);
		planetText.text = "Number of Planets to win: 10";
	}

	public void Planets20()
	{
		PlayerPrefs.SetInt("Planets", 20);
		planetText.text = "Number of Planets to win: 20";
	}

	public void Planets30()
	{
		PlayerPrefs.SetInt("Planets", 30);
		planetText.text = "Number of Planets to win: 30";
	}
}
