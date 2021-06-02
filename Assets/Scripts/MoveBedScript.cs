using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBedScript : MonoBehaviour
{
    public bool visitedRoom;

    public bool isTrigger;

    public float thrust = 1.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    private void OnTriggerEnter(Collider other)
    {
        isTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isTrigger = false;
    }

    private void Update()
    {
        if (isTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
            }
        }
    }

    private void OnGUI()
    {
        if (isTrigger)
        {
            GUI.Box(new Rect(0, 0, 200, 25), "Nyomj E-t, hogy arrébb lökd");
        }
    }
}
