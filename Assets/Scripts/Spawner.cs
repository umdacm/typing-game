using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public float minx, maxx, miny, maxy;
    public GameObject spawnedObj;
    [Range(0, 10)]
    //We should probably limit this to between 0.01 and 0.05
    public float spawnTimer;

    private bool routineRunning = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (!routineRunning)
        {
            StartCoroutine(Spawn(spawnTimer));
        }
	}

    // Spawns the object after a certain amount of time
    IEnumerator Spawn(float time)
    {
        routineRunning = true;
        yield return new WaitForSeconds(time);
        Instantiate(spawnedObj, new Vector3(transform.position.x + Random.Range(minx, maxx), transform.position.y + Random.Range(miny, maxy), transform.position.z), Quaternion.identity, transform);
        routineRunning = false;
    }

    // TODO Add a function that despawns the bubbles.

}