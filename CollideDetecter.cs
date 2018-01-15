using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideDetecter : MonoBehaviour {

    public GameObject explode;
    public Transform player;
    public GameObject enemy,player2,gameoverPanel;
    public ScoreCounter scoreVariable;
    public AudioSource explosionEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Enemy") {
            Instantiate(explode, player.position, player.rotation);
            enemy.SetActive(false);
            player2.SetActive(false);
            explosionEffect.Play();
            //wait for 2 seconds or something than transform the players position set active the enemy and after this score shouldn't increase
            Invoke("OpenPanel", 1f);

        }
    }

    void OpenPanel() {
        //SceneManager.LoadScene("MainScene");
        Time.timeScale = 0f;
        gameoverPanel.SetActive(true);

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explode, player.position, player.rotation);
            enemy.SetActive(false);
            player2.SetActive(false);
            explosionEffect.Play();
            Invoke("OpenPanel", 1f);

        }
        if (collision.gameObject.tag == "GameLine")
        {
            Instantiate(explode, player.position, player.rotation);
            enemy.SetActive(false);
            player2.SetActive(false);
            explosionEffect.Play();
            Invoke("OpenPanel", 1f);
        }
        if (collision.gameObject.tag == "GameLines")
        {
            Instantiate(explode, player.position, player.rotation);
            enemy.SetActive(false);
            player2.SetActive(false);
            explosionEffect.Play();
            Invoke("OpenPanel", 1f);
        }
    }
}
