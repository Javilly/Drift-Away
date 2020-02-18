using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 6.0f;
    [SerializeField] private float jumpSpeed = 8.0f;
    [SerializeField] private float gravity = 20.0f;
    [SerializeField] private int maxJumpCap = 1;
    [SerializeField] SoundSystem mySoundSystem;

    private int currentJumpCount = 0;

    private Vector3 moveDirection = new Vector3(0, 0, 0);
    private CharacterController controller;

    private float inputAxisX;
    private float inputAxisY;
    private float inputAxisZ;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }


    void FixedUpdate()
    {
        GetImput(ref inputAxisX, ref inputAxisY, ref inputAxisZ);
        Move();
        ResetJumpCount();
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("Generando sonido del player");
            mySoundSystem.generatePlayerSound();
        }
    }


    private void ResetJumpCount()
    {
        if (controller.isGrounded)
        {
            currentJumpCount = 0;
        }
    }

    private void Move()
    {
        moveDirection = new Vector3(inputAxisX, 0, inputAxisZ);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        if (!controller.isGrounded)
            inputAxisY -= gravity * Time.deltaTime;

        moveDirection.y = inputAxisY;

        controller.Move(moveDirection * Time.deltaTime);
    }

    private void GetImput(ref float inputX, ref float inputY, ref float inputZ)
    {

        inputX = Input.GetAxis("Horizontal");

        inputZ = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            Jump(ref inputY);
        }


    }

    private void Jump(ref float inputY)
    {
        if (currentJumpCount < maxJumpCap)
        {
            inputY = jumpSpeed;
            currentJumpCount++;
        }
    }
}
