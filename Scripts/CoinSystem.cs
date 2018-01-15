using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour {

    public Text cointext;
    private int Coin;
    public SpriteRenderer PlayerRenderer;
    public Sprite earth,planet1,planet2,planet3,planet4,planet5, planet6, planet7, planet8;
    public GameObject buybutton, buybutton2, buybutton3, buybutton4, buybutton5, buybutton6, buybutton7, buybutton8,
        errorMessage;
    public GameObject coinPrice, coinPrice2, coinPrice3, coinPrice4, coinPrice5, coinPrice6, coinPrice7, coinPrice8;
    public GameObject usebutton, usebutton2, usebutton3, usebutton4, usebutton5, usebutton6, usebutton7, usebutton8;
    public Text inuse, inuse2, inuse3, inuse4, inuse5, inuse6, inuse7, inuse8, inuse9;

    void Start () {
        Coin = PlayerPrefs.GetInt("Coin");
        cointext.text = Coin.ToString();
        if (PlayerPrefs.GetInt("BuyPlanet1") == 1)
        {
            buybutton.SetActive(false);
            coinPrice.SetActive(false);
            usebutton.SetActive(true);
        }
        if (PlayerPrefs.GetInt("BuyPlanet2") == 1)
        {
            usebutton2.SetActive(true);
            buybutton2.SetActive(false);
            coinPrice2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BuyPlanet3") == 1)
        {
            usebutton3.SetActive(true);
            buybutton3.SetActive(false);
            coinPrice3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BuyPlanet4") == 1)
        {
            usebutton4.SetActive(true);
            buybutton4.SetActive(false);
            coinPrice4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BuyPlanet5") == 1)
        {
            usebutton5.SetActive(true);
            buybutton5.SetActive(false);
            coinPrice5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BuyPlanet6") == 1)
        {
            usebutton6.SetActive(true);
            buybutton6.SetActive(false);
            coinPrice6.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BuyPlanet7") == 1)
        {
            usebutton7.SetActive(true);
            buybutton7.SetActive(false);
            coinPrice7.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BuyPlanet8") == 1)
        {
            usebutton8.SetActive(true);
            buybutton8.SetActive(false);
            coinPrice8.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PlayerSprite")==1)
        {
            inuse.text = "Equipped";
            inuse2.text = "Use";
            inuse3.text = "Use";
            inuse4.text = "Use";
            inuse5.text = "Use";
            inuse6.text = "Use";
            inuse7.text = "Use";
            inuse8.text = "Use";
            inuse9.text = "Use";
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 2)
        {
            inuse2.text = "Equipped";
            inuse.text = "Use";
            inuse3.text = "Use";
            inuse4.text = "Use";
            inuse5.text = "Use";
            inuse6.text = "Use";
            inuse7.text = "Use";
            inuse8.text = "Use";
            inuse9.text = "Use";
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 3)
        {
            inuse3.text = "Equipped";
            inuse.text = "Use";
            inuse2.text = "Use";
            inuse4.text = "Use";
            inuse5.text = "Use";
            inuse6.text = "Use";
            inuse7.text = "Use";
            inuse8.text = "Use";
            inuse9.text = "Use";
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 4)
        {
            inuse4.text = "Equipped";
            inuse.text = "Use";
            inuse3.text = "Use";
            inuse2.text = "Use";
            inuse5.text = "Use";
            inuse6.text = "Use";
            inuse7.text = "Use";
            inuse8.text = "Use";
            inuse9.text = "Use";
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 5)
        {
            inuse5.text = "Equipped";
            inuse.text = "Use";
            inuse3.text = "Use";
            inuse4.text = "Use";
            inuse2.text = "Use";
            inuse6.text = "Use";
            inuse7.text = "Use";
            inuse8.text = "Use";
            inuse9.text = "Use";
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 6)
        {
            inuse6.text = "Equipped";
            inuse.text = "Use";
            inuse3.text = "Use";
            inuse4.text = "Use";
            inuse5.text = "Use";
            inuse2.text = "Use";
            inuse7.text = "Use";
            inuse8.text = "Use";
            inuse9.text = "Use";
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 7)
        {
            inuse7.text = "Equipped";
            inuse.text = "Use";
            inuse8.text = "Use";
            inuse6.text = "Use";
            inuse9.text = "Use";
            inuse3.text = "Use";
            inuse4.text = "Use";
            inuse5.text = "Use";
            inuse2.text = "Use";
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 8)
        {
            inuse8.text = "Equipped";
            inuse.text = "Use";
            inuse9.text = "Use";
            inuse6.text = "Use";
            inuse7.text = "Use";
            inuse3.text = "Use";
            inuse4.text = "Use";
            inuse5.text = "Use";
            inuse2.text = "Use";
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 9)
        {
            inuse9.text = "Equipped";
            inuse.text = "Use";
            inuse8.text = "Use";
            inuse6.text = "Use";
            inuse7.text = "Use";
            inuse3.text = "Use";
            inuse4.text = "Use";
            inuse5.text = "Use";
            inuse2.text = "Use";
        }

    }
    void Update()
    {
        cointext.text = Coin.ToString();
    }

    public void BuyPlanet1()
    {
        if (Coin >= 200)
        {
            Coin = Coin - 200;
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.SetInt("BuyPlanet1", 1);
            buybutton.SetActive(false);
            coinPrice.SetActive(false);
            usebutton.SetActive(true);
            cointext.text = Coin.ToString();
        }
        else
        {
            Time.timeScale = 1f;
            errorMessage.SetActive(true);
            Invoke("ErrorMesage", 1f);
        }
    }
    public void BuyPlanet2()
    {
        if (Coin >= 500)
        {
            Coin = Coin - 500;
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.SetInt("BuyPlanet2", 1);
            buybutton2.SetActive(false);
            coinPrice2.SetActive(false);
            usebutton2.SetActive(true);
            cointext.text = Coin.ToString();
        }
        else
        {
            Time.timeScale = 1f;
            errorMessage.SetActive(true);
            Invoke("ErrorMesage", 1f);
        }
    }
    public void BuyPlanet3()
    {
        if (Coin >= 850)
        {
            Coin = Coin - 850;
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.SetInt("BuyPlanet3", 1);
            buybutton3.SetActive(false);
            coinPrice3.SetActive(false);
            usebutton3.SetActive(true);
            cointext.text = Coin.ToString();
        }
        else
        {
            Time.timeScale = 1f;
            errorMessage.SetActive(true);
            Invoke("ErrorMesage", 1f);
        }
    }
    public void BuyPlanet4()
    {
        if (Coin >= 1300)
        {
            Coin = Coin - 1300;
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.SetInt("BuyPlanet4", 1);
            buybutton4.SetActive(false);
            coinPrice4.SetActive(false);
            usebutton4.SetActive(true);
            cointext.text = Coin.ToString();
        }
        else
        {
            Time.timeScale = 1f;
            errorMessage.SetActive(true);
            Invoke("ErrorMesage", 1f);
        }
    }
    public void BuyPlanet5()
    {
        if (Coin >= 1750)
        {
            Coin = Coin - 1750;
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.SetInt("BuyPlanet5", 1);
            buybutton5.SetActive(false);
            coinPrice5.SetActive(false);
            usebutton5.SetActive(true);
            cointext.text = Coin.ToString();
        }
        else
        {
            Time.timeScale = 1f;
            Invoke("ErrorMesage", 1f);
            errorMessage.SetActive(true);
        }

    }
    public void BuyPlanet6()
    {
        if (Coin >= 2600)
        {
            Coin = Coin - 2600;
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.SetInt("BuyPlanet6", 1);
            buybutton6.SetActive(false);
            coinPrice6.SetActive(false);
            usebutton6.SetActive(true);
            cointext.text = Coin.ToString();
        }
        else
        {
            Time.timeScale = 1f;
            Invoke("ErrorMesage", 1f);
            errorMessage.SetActive(true);
        }

    }
    public void BuyPlanet7()
    {
        if (Coin >= 3250)
        {
            Coin = Coin - 3250;
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.SetInt("BuyPlanet7", 1);
            buybutton7.SetActive(false);
            coinPrice7.SetActive(false);
            usebutton7.SetActive(true);
            cointext.text = Coin.ToString();
        }
        else
        {
            Time.timeScale = 1f;
            Invoke("ErrorMesage", 1f);
            errorMessage.SetActive(true);
        }

    }
    public void BuyPlanet8()
    {
        if (Coin >= 3650)
        {
            Coin = Coin - 3650;
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.SetInt("BuyPlanet8", 1);
            buybutton8.SetActive(false);
            coinPrice8.SetActive(false);
            usebutton8.SetActive(true);
            cointext.text = Coin.ToString();
        }
        else
        {
            Time.timeScale = 1f;
            Invoke("ErrorMesage", 1f);
            errorMessage.SetActive(true);
        }

    }
    void ErrorMesage()
    {
        Time.timeScale = 0f;
        errorMessage.SetActive(false);
    }
    ///*///////////Use Methods
    public void UseEarth () {
        PlayerPrefs.SetInt("PlayerSprite",1);
        inuse.text = "Equipped";
        inuse2.text = "Use";
        inuse3.text = "Use";
        inuse4.text = "Use";
        inuse5.text = "Use";
        inuse6.text = "Use";
        inuse7.text = "Use";
        inuse8.text = "Use";
        inuse9.text = "Use";
        PlayerRenderer.sprite = earth;
	}
    public void UsePlanet1()
    {
        PlayerPrefs.SetInt("PlayerSprite", 2);
        inuse2.text = "Equipped";
        inuse.text = "Use";
        inuse3.text = "Use";
        inuse4.text = "Use";
        inuse5.text = "Use";
        inuse6.text = "Use";
        inuse7.text = "Use";
        inuse8.text = "Use";
        inuse9.text = "Use";
        PlayerRenderer.sprite = planet1;
    }
    public void UsePlanet2()
    {
        PlayerPrefs.SetInt("PlayerSprite", 3);
        inuse3.text = "Equipped";
        inuse2.text = "Use";
        inuse.text = "Use";
        inuse4.text = "Use";
        inuse5.text = "Use";
        inuse6.text = "Use";
        inuse7.text = "Use";
        inuse8.text = "Use";
        inuse9.text = "Use";
        PlayerRenderer.sprite = planet2;
    }
    public void UsePlanet3()
    {
        PlayerPrefs.SetInt("PlayerSprite", 4);
        inuse4.text = "Equipped";
        inuse.text = "Use";
        inuse3.text = "Use";
        inuse2.text = "Use";
        inuse5.text = "Use";
        inuse6.text = "Use";
        inuse7.text = "Use";
        inuse8.text = "Use";
        inuse9.text = "Use";
        PlayerRenderer.sprite = planet3;
    }
    public void UsePlanet4()
    {
        PlayerPrefs.SetInt("PlayerSprite", 5);
        inuse5.text = "Equipped";
        inuse.text = "Use";
        inuse3.text = "Use";
        inuse4.text = "Use";
        inuse2.text = "Use";
        inuse6.text = "Use";
        inuse7.text = "Use";
        inuse8.text = "Use";
        inuse9.text = "Use";
        PlayerRenderer.sprite = planet4;
    }
    public void UsePlanet5()
    {
        PlayerPrefs.SetInt("PlayerSprite", 6);
        inuse6.text = "Equipped";
        inuse7.text = "Use";
        inuse8.text = "Use";
        inuse9.text = "Use";
        inuse.text = "Use";
        inuse3.text = "Use";
        inuse4.text = "Use";
        inuse5.text = "Use";
        inuse2.text = "Use";
        PlayerRenderer.sprite = planet5;
    }
    public void UsePlanet6()
    {
        PlayerPrefs.SetInt("PlayerSprite", 7);
        inuse7.text = "Equipped";
        inuse.text = "Use";
        inuse9.text = "Use";
        inuse6.text = "Use";
        inuse8.text = "Use";
        inuse3.text = "Use";
        inuse4.text = "Use";
        inuse5.text = "Use";
        inuse2.text = "Use";
        PlayerRenderer.sprite = planet6;
    }
    public void UsePlanet7()
    {
        PlayerPrefs.SetInt("PlayerSprite", 8);
        inuse8.text = "Equipped";
        inuse.text = "Use";
        inuse9.text = "Use";
        inuse6.text = "Use";
        inuse7.text = "Use";
        inuse3.text = "Use";
        inuse4.text = "Use";
        inuse5.text = "Use";
        inuse2.text = "Use";
        PlayerRenderer.sprite = planet7;
    }
    public void UsePlanet8()
    {
        PlayerPrefs.SetInt("PlayerSprite", 9);
        inuse9.text = "Equipped";
        inuse.text = "Use";
        inuse8.text = "Use";
        inuse6.text = "Use";
        inuse7.text = "Use";
        inuse3.text = "Use";
        inuse4.text = "Use";
        inuse5.text = "Use";
        inuse2.text = "Use";
        PlayerRenderer.sprite = planet8;
    }

}
