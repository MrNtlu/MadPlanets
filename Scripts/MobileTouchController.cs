using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileTouchController : MonoBehaviour, IPointerUpHandler,IPointerDownHandler
{
    public Rigidbody2D player;
    public Transform playerci;
    public Transform playersprite;
    public float up;
    public bool left;
    public float rotate;

    void Start()
    {
        left = false;
 
    }

    void Update()
    {
        rotate = playersprite.eulerAngles.z;
        if (left)
        {
            rotate = rotate + 5f;
            player.AddForce(playerci.up * up);
            player.AddForce(-playerci.right * (up / 5f)*1.6f);
            playersprite.eulerAngles = new Vector3(0, 0, rotate);
        }

    }
    public void OnPointerUp(PointerEventData data)
    {
        left = false;
    }
    public void OnPointerDown(PointerEventData data)
    {
        left = true;
    }
}
