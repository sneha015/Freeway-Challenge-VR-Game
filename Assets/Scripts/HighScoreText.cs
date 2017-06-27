using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScoreText : MonoBehaviour {

	GameState state;
	// Use this for initialization
	void Start () {
        state = GameObject.FindObjectOfType<GameState>();
    
    }

	void Update()
	{
		Text text = GetComponent<Text>();
		text.text = "High Score: " + state.highScore + " meters.";
	}
		
}
