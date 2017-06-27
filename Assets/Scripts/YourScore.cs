using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YourScore : MonoBehaviour {
	GameState state;
		void Start () {
			state = GameObject.FindObjectOfType<GameState>();
			

		}
	void Update()
	{
		Text text = GetComponent<Text>();
		text.text = "Your Score: " + state.yourScore + " meters.";
	}
}
