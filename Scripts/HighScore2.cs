using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore2 : MonoBehaviour {

    public Text scoreTexter,highscoretext;
    public ScoreCounter scoree;

    void Start () {
        HighScoreStore();
        highscoretext.text = PlayerPrefs.GetInt("HighScore2").ToString();
	}
	
	void HighScoreStore () {
        if (scoree.Score >= PlayerPrefs.GetInt("HighScore2"))
        {
            PlayerPrefs.SetInt("HighScore2", scoree.Score);
            highscoretext.text = PlayerPrefs.GetInt("HighScore2").ToString() ;
        }
    }
}
