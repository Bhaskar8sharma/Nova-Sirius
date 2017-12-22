using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

    int Score = 0;
    public Text ScoreText;
	// Use this for initialization
	void Start () {
		
	}	
	// Update is called once per frame
	void Update () {
		
	}
    public void IncrementScore()
    {
        Score++;
        ScoreText.text = "Score: " + Score;
    }
}
