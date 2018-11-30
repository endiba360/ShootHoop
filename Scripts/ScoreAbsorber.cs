﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour {
	public int score;
	
	
	// Use this for initialization
	void Start () {
		ScoreKeep oldKeeper = FindObjectOfType<ScoreKeep>();
		
		score = oldKeeper.score;
		Destroy(oldKeeper.gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
