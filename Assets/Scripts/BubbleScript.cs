using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour {
    // Use this for initialization
    void Start () {
        GetComponentInChildren<TextMesh>().text = NameGen.GetName();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
