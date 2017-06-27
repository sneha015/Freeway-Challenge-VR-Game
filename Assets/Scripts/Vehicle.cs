using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {

    private float speed;
    private float length;
	private LevelState state;

	// Use this for initialization
	void Start () {
		state = GameObject.FindObjectOfType<LevelState>();
        float lifeTime = length / speed;
        Invoke("Remove", lifeTime);
	}

    void Remove()
    {
        Destroy(gameObject);
    }

    public void SetPath(float someSpeed, float someLength)
    {
        speed = someSpeed;
        length = someLength;
    }
	
	// Update is called once per frame
	void Update () {
		if (!state.IsGameOver) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		} 
	}
}
