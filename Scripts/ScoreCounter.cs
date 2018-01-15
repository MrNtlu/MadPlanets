using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    public int Score;
    public bool scorebool;
    public Text scoreText;
    //private GameObject enemies;
    public int Coin,Coinci,Coinlik;
    public Text CoinText;

	void Start () {
        scoreText.text = 0.ToString();
        Score = 0;
        CoinText.text = PlayerPrefs.GetInt("Coin").ToString();
        if (PlayerPrefs.HasKey("Coin") == false)
        {
            PlayerPrefs.SetInt("Coin", 0);
        }
        else
            Coin = PlayerPrefs.GetInt("Coin");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Score = Score + 10;
            scoreText.text = Score.ToString() ;
            /////////////////
            Coin=Coin+2;
            
            /*if (Coin == 0)
            {
                Coin = PlayerPrefs.GetInt("Coin");
            }*/
            /*else
                Coinci = Coin + Coinci;*/

            PlayerPrefs.SetInt("Coin", Coin);
            Coin = PlayerPrefs.GetInt("Coin");
            CoinText.text = Coin.ToString();

        }
    }

}
