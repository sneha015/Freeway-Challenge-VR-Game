using UnityEngine;
using System.Collections;

public class LethalCollider : MonoBehaviour {

	public AudioSource[] sounds;
	AudioSource VehicleSound;
	AudioSource crashSound;

	void Start()
	{
		VehicleSound = sounds [0];
		crashSound = sounds [1];
	}

	void OnCollisionEnter(Collision collision)
    {
		crashSound.Play ();
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            LevelState state = GameObject.FindObjectOfType<LevelState>();
			crashSound.Play ();
			VehicleSound.Stop ();
			state.IsGameOver = true;

        }
    }
}
