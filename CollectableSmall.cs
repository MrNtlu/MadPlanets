using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSmall : MonoBehaviour {

    public Transform player,makesmalltransform;
    public GameObject makesmall;
    public float minwait, maxwait,activetime;
    public float howmany;
    public AudioSource popsound;
	void Start () {
        minwait = 7.1f;
        maxwait = 11f;
        InvokeRepeating("SpawnCollectable",minwait,maxwait);
        activetime = 5f;
    }
    void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.gameObject.tag == "Player")
        {
            popsound.Play();
            if (player.localScale.x == 1f && player.localScale.y == 1f && player.localScale.z == 1f)
            {
                player.localScale=new Vector3(0.8f,0.8f,1f);
                Invoke("AfterPick", activetime);
            }
            if (player.localScale.x == 1.25f && player.localScale.y == 1.25f && player.localScale.z == 1f)
            {
                player.localScale = new Vector3(1f, 1f, 1f);
            }
            makesmall.SetActive(false);
        }
    }

    void AfterPick()
    {
        player.localScale = new Vector3(1f, 1f, 1f);

    }

    void Update () {
        GameObject[] collectables = GameObject.FindGameObjectsWithTag("Collectable");
        howmany = collectables.Length;
    }
    void SpawnCollectable()
    {
        GameObject[] collectabler = GameObject.FindGameObjectsWithTag("Collectable");

        if (howmany<3f) {
            Instantiate(makesmall, new Vector3(Random.Range(-2.3f, 2.3f), Random.Range(-4.5f, 3.8f), 0f), makesmalltransform.rotation);
            //Invoke("After3Sec", 8f);
        }

        if (howmany >= 3f && collectabler.Length >= 3f)
        {
            collectabler[1].SetActive(false);
            Instantiate(makesmall, new Vector3(Random.Range(-2.3f, 2.3f), Random.Range(-4.5f, 3.8f), 0f), makesmalltransform.rotation);
        }
    }

    void After3Sec()
    {
        makesmall.SetActive(false);
    }

}
