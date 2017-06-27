using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

    public int highScore;
	public int yourScore;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateHighScore(int newScore)
    {
		yourScore = newScore;
        if (newScore > highScore)
        {
            highScore = newScore;
        }
    }
}
