using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMov : MonoBehaviour
{
    Rigidbody myRb;
    BoxCollider myBC;
    Main mainI;
    float move;
    [SerializeField] float MSpeed = 5f, AMSpeed = 1f, JMax = 4f, JATime = 0.5f, grav = 11f, speed=1;
    [SerializeField] float Dx=0.5f, GroundDetectionY = 0.5f;
    float lastZ = 0;
    Vector3 nextpos;

    private void Start()
    {
        lastZ = transform.position.z;
        //nextpos = transform.position - (transform.forward * 1.5f);
        myBC = GetComponent<BoxCollider>();
        myRb = GetComponent<Rigidbody>();
        mainI = new Main();
        mainI.mov.Enable();
        mainI.mov.LR.performed += LRp;
        mainI.mov.LR.canceled += LRp;
        mainI.mov.Jump.performed += Jp;
        mainI.mov.Jump.canceled += Jc;
        mainI.mov.BF.performed += BFp;
    }

    private void BFp(InputAction.CallbackContext obj)
    {
        if (obj.ReadValue<float>() > 0 && nextpos==Vector3.zero)
        {
            nextpos = transform.position + (transform.forward * 1.5f);
            if (nextpos.z > lastZ +0.5f)
                nextpos = Vector3.zero;
        }
        else if (nextpos == Vector3.zero)
        {
            nextpos = transform.position - (transform.forward * 1.5f);
            if (nextpos.z < (lastZ-3) - 0.5f)
                nextpos = Vector3.zero;
        }
    }

    bool jump = false;

    bool grounded()
    {
        return Physics.BoxCast(transform.position + myBC.center, new Vector3(myBC.size.x/2,GroundDetectionY/2,myBC.size.z/2),-Vector3.up,Quaternion.identity,myBC.size.y/2, LayerMask.GetMask("Default"));
    }

    bool freepass(float dist)
    {
        return Physics.BoxCast(transform.position + myBC.center, new Vector3(myBC.size.x / 2, myBC.size.x / 2, GroundDetectionY / 2), Vector3.forward * (dist > 0 ? 1 : -1), Quaternion.identity, (Math.Abs(dist) + (myBC.size.z / 2) - GroundDetectionY / 2), LayerMask.GetMask("Default"));
    }

    private void Jp(InputAction.CallbackContext obj)
    {
        //Debug.Log(time2);
        if (obj.ReadValue<float>()>0&&grounded())
        {
            jump = true;
        }
    }

    private void Jc(InputAction.CallbackContext obj)
    {
        time2 = 0;
        jump = false;
    }

    void OnDrawGizmosSelected()
    {
        myBC = GetComponent<BoxCollider>();
        // Draw a semitransparent blue cube at the transforms position
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube((transform.position + myBC.center) -(Vector3.up * myBC.size.y / 2), new Vector3(myBC.size.x / 2, GroundDetectionY / 2, myBC.size.z / 2)*2);
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube((transform.position)+myBC.center, new Vector3(myBC.size.x / 2, GroundDetectionY / 2, myBC.size.z / 2) * 2);
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube((transform.position) + myBC.center, new Vector3(myBC.size.x / 2, myBC.size.x / 2, GroundDetectionY / 2) * 2);
        Gizmos.color = new Color(0, 0, 1, 0.5f);
        Gizmos.DrawCube((transform.position) + myBC.center + (Vector3.forward * ((Math.Abs(1.5f) + (myBC.size.z / 2) - GroundDetectionY / 2) * (1.5f > 0 ? 1 : -1))), new Vector3(myBC.size.x / 2, myBC.size.x / 2, GroundDetectionY / 2) * 2);

    }

    float time = 0, time2 = 0;

    private void FixedUpdate()
    {
        //Debug.Log(grounded());
        //Debug.Log(move);
        if (myRb.velocity.x == 0)
        {
            time = 0;
        }
        if (Math.Abs(myRb.velocity.x) < (MSpeed*0.9f) && move != 0) {
            time += Time.fixedDeltaTime;
            myRb.velocity = new Vector3(MSpeed * move *(time/AMSpeed), myRb.velocity.y, myRb.velocity.z);
        } else if (move != 0) {
            time = 0;
            myRb.velocity = new Vector3(MSpeed * move, myRb.velocity.y, myRb.velocity.z);
        }
        if (jump)
        {
            if (time2 < JATime)
            {
                time2 += Time.fixedDeltaTime;
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
        //Debug.Log(freepass(-1.5f));
        if (nextpos!=Vector3.zero && !freepass(nextpos.z<transform.position.z?-1.5f:1.5f)) {
            if (Math.Abs((transform.position - nextpos).z) > 0.001f)
            {
                myRb.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotation;
                float step = speed * Time.fixedDeltaTime;
                myRb.MovePosition(Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,transform.position.y,nextpos.z), step));
            }
            else
            {
                nextpos = Vector3.zero;
                myRb.MovePosition(myRb.position);
                myRb.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
            }
        }else if (nextpos != Vector3.zero)
        {
            nextpos = Vector3.zero;
        }
        if(myRb.position.z > (lastZ + 0.25f))
        {
            myRb.position = new Vector3(myRb.position.x, myRb.position.y, lastZ);
        }else if(myRb.position.z < (lastZ - 3f - 0.25f))
        {
            myRb.position = new Vector3(myRb.position.x, myRb.position.y, lastZ-3f);
        }
        //myRb.MovePosition(transform.position + transform.right * Time.fixedDeltaTime);
    }

    private void LRp(InputAction.CallbackContext obj)
    {
        move = obj.ReadValue<float>();
    }
}
