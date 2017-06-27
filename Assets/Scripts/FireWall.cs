using UnityEngine;
using System.Collections;

public class FireWall : MonoBehaviour {

    public float creepSpeed = 0.5f;

    private Player player;
    private LevelState state;
	private AudioSource fireSound; 

	// Use this for initialization
	void Start () {
		fireSound = GetComponent<AudioSource> ();
        player = GameObject.FindObjectOfType<Player>();
        state = GameObject.FindObjectOfType<LevelState>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!state.IsGameOver)
        {
            FollowPlayer();
            CreepForward();
            CheckPlayerBurnt();
        }
    }

    void FollowPlayer ()
    {
        Vector3 delta = player.transform.position - transform.position;
		if (delta.z < 2) {
			if (!fireSound.isPlaying) {
				fireSound.Play ();
			}
		}
        Vector3 projectedDelta = Vector3.Project(delta, Vector3.left);
        transform.position += projectedDelta;
    }


    void CreepForward ()
    {
        transform.position += Vector3.forward * creepSpeed;
    }

    void CheckPlayerBurnt()
    {
        if (player.transform.position.z < transform.position.z)
        {
            state.IsGameOver = true;
        }
    }
}
