using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float speed;
    private Vector3 cameraPos, startPos;
    private float t = 0;
	// Use this for initialization
	void Start () {
        startPos = transform.position;
        cameraPos = Camera.main.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(startPos, cameraPos, t);
        t += speed * Time.deltaTime;
	}
}
