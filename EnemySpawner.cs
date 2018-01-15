using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour {

	public float startWait=1f;
    public float minwait, maxwait;
	public Vector2 spawnValues;
	//public float spawnWait, spawnMostWait, spawnLeastWait;
	public Transform[] spawnPoints;
	public bool stop;
	public GameObject enemy;
    //int randEnemy;
    public ScoreCounter scoreCounter;
    public ForceToRight forcetoright;

    public float maxwaitmin, maxwaitmax;

    int spriteRandomizer;
    public SpriteRenderer mars;
    public Sprite[] marssprite;

	void Start () {
        //StartCoroutine (Spawner());
		InvokeRepeating("Spawn",minwait,maxwait);
        maxwaitmin = 1.3f;
        maxwaitmax=2f;
	}

    private void FixedUpdate()
    {
        if (scoreCounter.Score >= 0f && scoreCounter.Score <= 150)
        {
            maxwaitmin = 1.3f;
            maxwaitmax = 2f;
        }
        if (scoreCounter.Score>150 && scoreCounter.Score <= 300)
        {
            maxwaitmin = 1.25f;
            maxwaitmax = 1.97f;
            forcetoright.forcetoRigt = 215f;
        }
        if (scoreCounter.Score > 300 && scoreCounter.Score <= 500)
        {
            maxwaitmin = 1.15f;
            maxwaitmax = 1.85f;
        }
        if (scoreCounter.Score > 500 && scoreCounter.Score <= 750)
        {
            maxwaitmin = 1f;
            maxwaitmax = 1.7f;
            forcetoright.forcetoRigt = 240f;
        }
        if (scoreCounter.Score > 750 && scoreCounter.Score <= 1000)
        {
            maxwaitmin = 0.9f;
            maxwaitmax = 1.55f;
            forcetoright.forcetoRigt = 280f;
        }
        if (scoreCounter.Score > 1000 && scoreCounter.Score <= 1300)
        {
            maxwaitmin = 0.8f;
            maxwaitmax = 1.4f;
            forcetoright.forcetoRigt = 325f;

        }
        if (scoreCounter.Score > 1300 && scoreCounter.Score <= 1500)
        {
            maxwaitmin = 0.72f;
            maxwaitmax = 1.35f;
            forcetoright.forcetoRigt = 360f;
        }
        if (scoreCounter.Score > 1500 && scoreCounter.Score <= 1800)
        {
            maxwaitmin = 0.68f;
            maxwaitmax = 1.28f;
            forcetoright.forcetoRigt = 395f;
        }
        if (scoreCounter.Score > 1800 && scoreCounter.Score <= 2000)
        {
            maxwaitmin = 0.65f;
            maxwaitmax = 1.23f;
            forcetoright.forcetoRigt = 430f;
        }
        if (scoreCounter.Score > 2000 && scoreCounter.Score <= 2500)
        {
            maxwaitmin = 0.61f;
            maxwaitmax = 1.12f;
            forcetoright.forcetoRigt = 455f;
        }
        if (scoreCounter.Score > 2500 && scoreCounter.Score <= 3000)
        {
            maxwaitmin = 0.55f;
            maxwaitmax = 1.1f;
            forcetoright.forcetoRigt = 500f ;
        }
        else
        {
            if (maxwaitmin >= 0.34f && maxwaitmax >= 0.81f)
            {
                maxwaitmin = maxwaitmin - 0.001f;
                maxwaitmax = maxwaitmax - 0.001f;
            }
            else
            {
                maxwaitmin = 0.3399f;
                maxwaitmax = 0.8099f;
                forcetoright.forcetoRigt = 532f;
            }
            
        }
    }

    private void Update()
    {
        maxwait = Random.Range(maxwaitmin, maxwaitmax);
        spriteRandomizer = Random.RandomRange(0, marssprite.Length);
    }
    void Spawn () {
        mars.sprite = marssprite[spriteRandomizer];
        int spawnPointindex = Random.Range (0,spawnPoints.Length);
		Instantiate(enemy,spawnPoints[spawnPointindex].position,spawnPoints[spawnPointindex].rotation);
	}


	/*
	IEnumerator Spawner(){
		yield return new WaitForSeconds (startWait);
		while (true) {
			randEnemy = Random.Range (0, 6);
			// 4.3 - -4.4
			Vector2 spawnPosition=new Vector2(-3.4f,Random.Range(-4.4f,4.3f));
			Instantiate (enemy [randEnemy], spawnPosition, gameObject.transform.rotation);
			yield return new WaitForSeconds (spawnWait);
		}
	}*/
}
