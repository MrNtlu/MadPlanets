﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text scoreTexter;
    public ScoreCounter scoree;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreTexter.text = scoree.Score.ToString();
	}
}