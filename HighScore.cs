using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public Text scoreTexter,highscoretext;
    public ScoreCounter scoree;

    void Start () {
        HighScoreStore();
        highscoretext.text = PlayerPrefs.GetInt("HighScore").ToString();
	}
	
	void HighScoreStore () {
        if (scoree.Score >= PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scoree.Score);
            highscoretext.text = PlayerPrefs.GetInt("HighScore").ToString() ;
        }
    }
}
