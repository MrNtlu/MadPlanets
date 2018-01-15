using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D player;
	public Transform playerci;
	public float up;

	void Start () {
		
	}
	
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			player.AddForce (playerci.up*up);
			player.AddForce (playerci.right*(up/5f));
		}
		if(Input.GetButtonDown("Fire2")){
			player.AddForce (playerci.up*up);
			player.AddForce (-playerci.right*(up/5f));
		}
	}
}
