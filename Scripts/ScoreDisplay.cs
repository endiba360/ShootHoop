using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreDisplay : MonoBehaviour {
	ScoreKeep scoreKeep;
	Text text;
	
	
	// Use this for initialization
	void Start () {
		scoreKeep = FindObjectOfType<ScoreKeep>();
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: "+scoreKeep.score;
	}
}
