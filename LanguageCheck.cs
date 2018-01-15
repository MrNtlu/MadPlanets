using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageCheck : MonoBehaviour {

    public Text startbutton, menubutton, shopmenubutton;
    public Text shoperror,gamename,newgamemodetext;


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
        startbutton.text = "Başla";
        menubutton.text = "Dükkan";
        shopmenubutton.text = "Menü";
        shoperror.text = "Yeterli Krediniz Yok!";
        gamename.text = "Çılgın Gezegenler";
        newgamemodetext.text = "TekYön";
	}
    void EnglishTexts()
    {
        gamename.text = "Mad Planets";
        startbutton.text = "Start";
        menubutton.text = "Shop";
        shopmenubutton.text = "Menu";
        shoperror.text = "You Don't Have Enough Credits!";
        newgamemodetext.text = "OneWay";

    }
}
