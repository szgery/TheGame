using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpenKey : MonoBehaviour
{
    public PlayerMovement player;

    public bool IsTrigger;
    public bool InInventory;
    public MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            mesh.enabled = false;
            InInventory = true;
            player.key = true;

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        IsTrigger = true; 
    }

    private void OnTriggerExit(Collider other)
    {
        IsTrigger = false;
    }

    private void OnGUI()
    {
        if (player.key == false)
        {
            if (IsTrigger)
            {
                GUI.Box(new Rect(0, 0, 215, 25), "Nyomj F-et, hogy felvedd a kulcsot");
            }
        }
        
    }

}
