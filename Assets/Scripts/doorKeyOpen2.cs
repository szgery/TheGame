using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorKeyOpen2 : MonoBehaviour
{
    public PlayerMovement player;
    public MeshRenderer mesh;

    public bool IsTrigger;

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        IsTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        IsTrigger = false;
    }

    void Update()
    {
        if (IsTrigger)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                mesh.enabled = false;
                player.keyExit = true;
            }
        }
    }

    private void OnGUI()
    {
        if (player.keyExit == false)
        {
            if (IsTrigger)
            {
                GUI.Box(new Rect(0, 0, 215, 25), "Nyomj F-et, hogy felvedd a kulcsot");
            }
        }
    }
}
