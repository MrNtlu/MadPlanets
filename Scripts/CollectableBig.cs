using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBig : MonoBehaviour {

    public Transform player,makebigtransform;
    public GameObject makebig;
    public float minwait, maxwait,activetime;
    public float howmanybig;
    public AudioSource popsound2;

    void Start () {
        minwait = 6.4f;
        maxwait = 9.5f;
        InvokeRepeating("SpawnCollectable",minwait,maxwait);
        activetime = 5f;
    }
    void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.gameObject.tag == "Player")
        {
            popsound2.Play();
            if (player.localScale.x == 1f && player.localScale.y == 1f && player.localScale.z == 1f)
            {
                Invoke("AfterPick", activetime);
                player.localScale=new Vector3(1.25f,1.25f,1f);

            }
            if (player.localScale.x == 0.8f && player.localScale.y == 0.8f && player.localScale.z == 1f)
            {
                player.localScale = new Vector3(1f, 1f, 1f);
            }
            makebig.SetActive(false);
        }
    }

    void AfterPick()
    {
        player.localScale = new Vector3(1f, 1f, 1f);
    }

    void Update () {
        GameObject[] collectables = GameObject.FindGameObjectsWithTag("Collectables");
        howmanybig = collectables.Length;
    }
    void SpawnCollectable()
    {
        GameObject[] collectabler = GameObject.FindGameObjectsWithTag("Collectables");
        if (howmanybig<2f) {
            Instantiate(makebig, new Vector3(Random.Range(-2.3f, 2.3f), Random.Range(-4.5f, 3.8f), 0f), makebigtransform.rotation);
            //Invoke("After3Sec",7.4f);
        }
        if (howmanybig >= 2f && collectabler.Length>=2f)
        {
            collectabler[1].SetActive(false);
            Instantiate(makebig, new Vector3(Random.Range(-2.3f, 2.3f), Random.Range(-4.5f, 3.8f), 0f), makebigtransform.rotation);
        }
    }

    void After3Sec()
    {
        makebig.SetActive(false);
    }

}
