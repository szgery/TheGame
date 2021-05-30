using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWithKey : MonoBehaviour
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
        if (player.key == true)
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
            audioSourceClose.Play();
        }
        else
        {
            //Az ajto nyitasa
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 100);
            transform.rotation = newRot;
            audioSource.Play();
        }

    }

    private void OnGUI()
    {
        if (inTrigger)
        {
            if (player.key == true)
            {
                if (open)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Nyomj E-t, hogy ajtót zárj!");
                }
                else
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Nyomj E-t, hogy ajtót nyiss!");
                }
            }
            else
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Kulcs szükséges a nyitáshoz!");
            }
        }
    }
}
