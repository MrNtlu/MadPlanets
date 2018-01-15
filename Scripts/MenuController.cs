using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public GameObject panelcim;
    public GameObject GameMenuCanvas,menuCanvas,gameoverpanel;
    public AudioSource music;

    private void Start()
    {
        
    }

    public void StartGame()
    {
        //GameMenuCanvas.SetActive(false);
        DontDestroyOnLoad(music);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");

    }

    public void Shop()
    {
        menuCanvas.SetActive(true);
    }

    public void ShopGoBack()
    {
        menuCanvas.SetActive(false);
        GameMenuCanvas.SetActive(true);
    }

    public void Pause()
    {
        panelcim.SetActive(true);
        Time.timeScale = 0f;
    }

    public void MainMenu () {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale =1f;
	}
    public void Resume()
    {
        panelcim.SetActive(false);
        Time.timeScale = 1f;
    }
    public void NewGameMode()
    {
        DontDestroyOnLoad(music);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene1");
    }
}
