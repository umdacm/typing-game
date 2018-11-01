using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    public Camera Maincam;

    float shakeAmount = 0;

    void Awake()
    {
         if (Maincam== null)
        {
            Maincam = Camera.main; 
        }
    }
   
    public void Shake(float amt, float lenght)
    {
        shakeAmount = amt;
        InvokeRepeating("BeginShake",0,0.01f);
        Invoke("StopShake",lenght);
    }

    void BeginShake()
    {
        if(shakeAmount > 0)
        {
            Vector3 camPos = Maincam.transform.position;

            float shakeAmtX = Random.value * shakeAmount * 2 - shakeAmount;
            float shakeAmtY = Random.value * shakeAmount * 2 - shakeAmount;
            camPos.x += shakeAmtX;
            camPos.y += shakeAmtY;

            Maincam.transform.position = camPos;
        }
    }

    void StopShake()
    {
        CancelInvoke("BeginShake");
        Maincam.transform.localPosition = Vector3.zero;
    }
}
