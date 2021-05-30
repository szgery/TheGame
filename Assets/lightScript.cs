using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightScript : MonoBehaviour
{
    public Light flashlight;

    // Start is called before the first frame update
    void Start()
    {
        flashlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            flashlight.enabled = true;
        }
    }
}
