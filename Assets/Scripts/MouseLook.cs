using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerTransform;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f)
        {
            
        }
        else
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -50f, 80f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerTransform.Rotate(Vector3.up * mouseX);
        }
        
    }
}
