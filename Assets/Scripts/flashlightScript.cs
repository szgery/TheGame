using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightScript : MonoBehaviour
{
    public Light flashlight;
    public bool isOn = false;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        flashlight = GetComponent<Light>();
        Debug.Log($"Counter erteke: {counter}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            flashlight.enabled = !flashlight.enabled;
        }
    }
}
