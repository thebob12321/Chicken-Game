﻿using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {

	public static int score;

	public Text text;

	// Use this for initialization
	void Start () {
		text= GetComponent<Text>();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0)
			score = 0;
			text.text = " " + score;
	}
			public static void Addpoints(int pointsToAdd){
				score += pointsToAdd;

			}
			public void Reset(){
				score=0;
			}


}

	