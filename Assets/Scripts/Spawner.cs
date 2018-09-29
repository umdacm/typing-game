using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public float minx, maxx, miny, maxy;
    public GameObject bubble;
    [Range(0, 1)]
    //We should probably limit this to between 0.01 and 0.05
    public float spawnRate = 0.02f;  

    private float spawnTimer = 0;

	// Use this for initialization
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {

        TrySpawn();

	}

    // This function will spawn a bubble within the bounds of minx,maxx,miny,maxy if it is time to do so
    // The way this function is set up it should make spawnRate act as a linear scale
    // between spawning never and spawning every single frame
    void TrySpawn()
    {

        // If the spawn timers is greater than or equal to 1 
        // then we spawn a bubble and reset the timer
        if (spawnTimer >= 1) {
            Instantiate(bubble, new Vector3(transform.position.x + Random.Range(minx, maxx), transform.position.y + Random.Range(miny, maxy), transform.position.z), Quaternion.identity, transform);
            spawnTimer = 0;
        }
        // Otherwise we add spawnRate to spawnTimer
        else
        {
            spawnTimer += spawnRate;
        }
    }

    // TODO Add a function that despawns the bubbles.

}