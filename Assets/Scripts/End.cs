using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour


{

    public string End_Scane;
    public bool IsTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTrigger)
        {
            SceneManager.LoadScene(End_Scane);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IsTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        IsTrigger = false;
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
