using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWithKey2 : MonoBehaviour
{
    public PlayerMovement player;

    public bool inTrigger;
    public bool open = true;
    public bool close = false;

    public AudioSource audioSource;
    public AudioSource audioSourceClose;


    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void Update()
    {
        //Kij?rati ajt?
        if (player.keyExit == true)
        {
            if (inTrigger)
            {
                if (close)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;
                    }

                }
                else
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        close = true;
                        open = false;
                    }

                }
            }
        }

        if (open)
        {

            //Az ajto nyitasa
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 90.0f, 0.0f), Time.deltaTime * 100);
            transform.rotation = newRot;
            audioSource.Play();
        }
        else
        {
            //Az ajto nyitasa
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 100);
            transform.rotation = newRot;
            audioSourceClose.Play();
        }

    }

    private void OnGUI()
    {
        //Kij?rati ajt? nyit?s GUI a 2. kulccsal
        if (inTrigger)
        {
            if (player.keyExit == true)
            {
                if (open)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Nyomj E-t, hogy ajt?t nyiss!");
                }
                else
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Nyomj E-t, hogy ajt?t z?rj!");
                }
            }
            else
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Kulcs sz?ks?ges a nyit?shoz!");
            }
        }
    }
}
