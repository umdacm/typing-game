using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        ScoreCounting.ScoreValue -= 10;
        // Here is where we would add something that takes away a life or points
        // or something bad that happens when you miss a bubble
    }

}
