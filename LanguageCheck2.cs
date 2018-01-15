using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageCheck2 : MonoBehaviour {

    public Text Tutorialnothit, tutorialleft, tutorialright, tutorialmaintext;
    public Text gameovermenu, gameoverrestart;
    public Text scoretext, gameoverscore, gameoverhighscore,pauseresume,pausemenu;
    public Text Collectablestext, Collectablestext2;

    void Start () {
        if (Application.systemLanguage==SystemLanguage.Turkish)
        {
            TurkishTexts();
        }
        if (Application.systemLanguage == SystemLanguage.English)
        {
            EnglishTexts();
        }
    }
	
	void TurkishTexts () {
        tutorialmaintext.text = "Egitim";
        tutorialleft.text = "Yukarı ve Sola Gitmek için Dokunun";
        tutorialright.text = "Yukarı ve Sağa Gitmek için Dokunun";
        Tutorialnothit.text = "Sakın carpmalarına izin verme!";
        gameovermenu.text = "Menü";
        gameoverrestart.text = "Tekrar";
        scoretext.text = "Skor:";
        gameoverscore.text = "Son Skorun:";
        gameoverhighscore.text = "Yüksek Skor:";
        pauseresume.text = "Devam";
        pausemenu.text = "Menü";
        Collectablestext.text = "Gri: Sizi Küçültür.";
        Collectablestext2.text= "Kırmızı: Sizi Büyültür.";
    }
    void EnglishTexts()
    {
        tutorialmaintext.text = "Tutorial";
        tutorialleft.text = "Click to Move Up and Left";
        tutorialright.text = "Click to Move Up and Right";
        Tutorialnothit.text = "Try not to hit them!!";
        gameovermenu.text = "Menu";
        gameoverrestart.text = "Restart";
        scoretext.text = "Score:";
        gameoverscore.text = "Your Score:";
        gameoverhighscore.text = "High Score:";
        pauseresume.text = "Resume";
        pausemenu.text = "Menu";
        Collectablestext.text = "Grey: Makes You Smaller";
        Collectablestext2.text = "Red: Makes you bigger";

    }
}
