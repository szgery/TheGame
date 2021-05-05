using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioHeartBeat : MonoBehaviour
{

    public int EnterCounter = 0;

    public AudioSource audioSource1;
    
    private void OnTriggerEnter(Collider other)
    {
        if (EnterCounter == 0)
        {
            audioSource1.Play();
        }

        EnterCounter += 1;
    }
}
