using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMov : MonoBehaviour
{
    Rigidbody myRb;
    Main mainI;
    float move;
    [SerializeField] float MSpeed = 5f, AMSpeed = 1f, JMax = 4f, JATime = 0.5f, grav = 11f;
    [SerializeField] float Dx=0.5f;
    private void Start()
    {
        myRb = GetComponent<Rigidbody>();
        mainI = new Main();
        mainI.mov.Enable();
        mainI.mov.LR.performed += LRp;
        mainI.mov.LR.canceled += LRp;
        mainI.mov.Jump.performed += Jp;
        mainI.mov.Jump.canceled += Jc;
    }
    bool jump = false;
    private void Jp(InputAction.CallbackContext obj)
    {
        //Debug.Log(time2);
        if (obj.ReadValue<float>()>0)
        {
            jump = true;
        }
    }

    private void Jc(InputAction.CallbackContext obj)
    {
        time2 = 0;
        jump = false;
    }

    float time = 0, time2 = 0;
    private void FixedUpdate()
    {
        //Debug.Log(move);
        if (myRb.velocity.x == 0)
        {
            time = 0;
        }
        if (Math.Abs(myRb.velocity.x) < (MSpeed*0.9f) && move != 0) {
            time += Time.deltaTime;
            myRb.velocity = new Vector3(MSpeed * move *(time/AMSpeed), myRb.velocity.y, myRb.velocity.z);
        } else if (move != 0) {
            time = 0;
            myRb.velocity = new Vector3(MSpeed * move, myRb.velocity.y, myRb.velocity.z);
        }
        if (jump)
        {
            if (time2 < JATime)
            {
                time2 += Time.deltaTime;
            }
            else
            {
                jump = false;
            }
            myRb.velocity = new Vector3(myRb.velocity.x, JMax, myRb.velocity.z);
        }
        else if(myRb.velocity.y<0)
        {
            myRb.velocity = new Vector3(myRb.velocity.x, myRb.velocity.y+(myRb.velocity.y*grav), myRb.velocity.z);
        }
        if (move == 0)
        {
            int mod = myRb.velocity.x > 0 ? 1 : -1;
            if (Math.Abs(myRb.velocity.x) > 0.25f)
            {
                myRb.velocity = new Vector3(myRb.velocity.x - (Dx*mod), myRb.velocity.y, myRb.velocity.z);
            }
            else if(myRb.velocity.x!=0)
            {
                myRb.velocity = new Vector3(0, myRb.velocity.y, myRb.velocity.z);
            }
        }
    }

    private void LRp(InputAction.CallbackContext obj)
    {
        move = obj.ReadValue<float>();
    }
}
