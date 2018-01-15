using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderCheck : MonoBehaviour {
    public SpriteRenderer PlayerRenderer;
    public Sprite earth, planet1, planet2, planet3, planet4, planet5, planet6, planet7, planet8;

    void Start () {
        if (PlayerPrefs.GetInt("PlayerSprite") == 1)
        {
            PlayerRenderer.sprite = earth;
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 2)
        {
            PlayerRenderer.sprite = planet1;
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 3)
        {
            PlayerRenderer.sprite = planet2;
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 4)
        {
            PlayerRenderer.sprite = planet3;
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 5)
        {
            PlayerRenderer.sprite = planet4;
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 6)
        {
            PlayerRenderer.sprite = planet5;
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 7)
        {
            PlayerRenderer.sprite = planet6;
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 8)
        {
            PlayerRenderer.sprite = planet7;
        }
        if (PlayerPrefs.GetInt("PlayerSprite") == 9)
        {
            PlayerRenderer.sprite = planet8;
        }
    }
	
	void Update () {
		
	}
}
