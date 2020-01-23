using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 6f;
    public float jumpSpeed = 8.0f;
    public float gravity = -9.81f;

    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        //if (controller.isGrounded)
        //{
        //    // We are grounded, so recalculate
        //    // move direction directly from axes

        //    moveDirection = new Vector3((float)Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        //    moveDirection *= speed;

        //    if (Input.GetButton("Jump"))
        //    {
        //        moveDirection.y = jumpSpeed;
        //    }
        //}

        //// Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        //// when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        //// as an acceleration (ms^-2)
        //moveDirection.y += gravity * Time.deltaTime;

        //// Move the controller
        //controller.Move(moveDirection * Time.deltaTime);

        if(controller.isGrounded)
        {
            moveDirection = Vector3.Normalize(transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if(Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        else
        {
            float prevY = moveDirection.y;

            moveDirection = Vector3.Normalize(transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical"));
            moveDirection *= speed / 2;

            moveDirection.y = prevY;
        }

        moveDirection.y += gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);

        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //Vector3 movement = Vector3.Normalize(transform.right * x + transform.forward * z);

        //controller.Move(movement * speed * Time.deltaTime);

        //if (controller.isGrounded)
        //{
        //    print("Player is not touching ground)");
        //    moveDirection.y += gravity * Time.deltaTime;
        //}

        //controller.Move(moveDirection * Time.deltaTime);

    }
}
