using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBehavOpen : MonoBehaviour
{
    public bool inTrigger;
    public bool close;
    public bool open;

    void OnTriggerEnter(Collider collider)
    {
        inTrigger = true;
    

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

    if (open)
    {
        var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
        transform.rotation = newRot;
    }
    else
    {
        var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
        transform.rotation = newRot;
    }
    
    
    }
}
