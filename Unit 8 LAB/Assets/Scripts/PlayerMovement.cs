using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f; //Run speed variable


    float horizontalMove = 0f;


    bool jump = false;

    bool crouch = false;



    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump")) //This sees if the Jump key has been pressed
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch")) //This sees if the Crouch key has been pressed
        {
            crouch = true;

        }else if (Input.GetButtonUp("Crouch")) //This sees if the Jump key has been let go
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        
    }

}
