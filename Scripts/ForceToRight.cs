using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceToRight : MonoBehaviour {

    public Rigidbody2D enemyBody;
    public Transform enemyTransform, enemysprite;
    public float forcetoRigt,rotationz;
	void Start () {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GameLines")
        {
            Invoke("Destroyer",1f);
        }
    }

    void Destroyer()
    {
        this.gameObject.SetActive(false);

    }



    void Update () {
        rotationz = rotationz - (forcetoRigt/50f);
        enemyBody.AddForce(enemyTransform.right * forcetoRigt * Time.deltaTime);
        enemysprite.eulerAngles = new Vector3(0, 0, rotationz);
    }
}
