using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScripts : MonoBehaviour {

	public Text lifeText;
	private int life;
	public Text scoreText;
	private int score;

	// Use this for initialization
	void Start () {

		this.lifeText.text = "100";

	}
	
	// Update is called once per frame
	void Update () {
	}

	private void paintScoreLife () {
		
		lifeText.text = "" + life.ToString ();
		scoreText.text = "Score: " + score.ToString ();
		
	}

	
}
