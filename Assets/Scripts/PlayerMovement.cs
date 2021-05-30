using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool key = false;

    public CharacterController characterController;

    public float speed = 8f;
    public float gravity = 20f;
    public float jumpHeight = 8.0f;

    private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        if (characterController == null)
            characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (characterController.isGrounded)
        {
            moveDirection = transform.right * horizontal + transform.forward * vertical;
            moveDirection *= speed;

            if(Input.GetButton("Jump"))
            {
                moveDirection.y = jumpHeight;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
