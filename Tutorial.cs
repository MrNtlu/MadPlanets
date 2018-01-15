using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

    public GameObject tutorialpanel;

    void Start() {
        if (PlayerPrefs.GetInt("Tutorial") == 1)
        {
            tutorialpanel.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            tutorialpanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
	public void turnoffTutorial()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Tutorial", 1);
        tutorialpanel.SetActive(false);
    }
}
