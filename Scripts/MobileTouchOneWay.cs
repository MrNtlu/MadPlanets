using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileTouchOneWay: MonoBehaviour, IPointerUpHandler,IPointerDownHandler
{
    public Rigidbody2D player;
    public Transform playerci;
    public float up;
    public bool right;

    void Start()
    {
        right = false;
    }

    void Update () {
        if (right) {
            player.AddForce(playerci.up * up);
        }

    }
    public void OnPointerUp(PointerEventData data)
    {
        right = false;
    }
    public void OnPointerDown (PointerEventData data) {
        right = true;
    }
}
