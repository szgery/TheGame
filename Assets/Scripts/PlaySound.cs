using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioSource audioSource2;

    public int EnterCounter = 0;

    public bool inTrigger;

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;        

        if (EnterCounter == 0)
        {
            audioSource.Play();
            //audioSource2.Play();
        }

        EnterCounter += 1;
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

}


