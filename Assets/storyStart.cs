using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyStart : MonoBehaviour
{
    public bool IsTrigger;

    private void OnTriggerEnter(Collider other)
    {
        IsTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        IsTrigger = false;
    }

    private void OnGUI()
    {
        if (IsTrigger)
        {
            GUI.Box(new Rect(0, 0, 200, 25), "Menj át a másik szobába!");
        }
    }
}
