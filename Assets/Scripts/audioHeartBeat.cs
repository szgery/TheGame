using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioHeartBeat : MonoBehaviour
{

    public int EnterCounter = 0;

    public AudioSource audioSource1;
    public DoorBehav doorBehav;
    
    private void OnTriggerEnter(Collider other)
    {
        if (EnterCounter == 0)
        {
            audioSource1.Play();
            doorBehav.close = true;
            doorBehav.open = false;
            doorBehav.audioSource.Play();
        }

        EnterCounter += 1;
    }
}
