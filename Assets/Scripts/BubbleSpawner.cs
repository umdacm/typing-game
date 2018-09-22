using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour {
    public float minx, maxx, miny, maxy;
    public GameObject bubble;
    public NameGen nameText = new NameGen();
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
        
            bubble.GetComponentInChildren<TextMesh>().text = nameText.GetName();

            Instantiate(bubble, new Vector2(transform.position.x + Random.Range(minx, maxx), transform.position.y + Random.Range(miny, maxy)), Quaternion.identity, transform);
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