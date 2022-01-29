using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class Movementball : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float drag = 0.5f;
    public float terminalRotationalSpeed = 25.0f;
    public Vector3 MoveVector { set; get; }
    public VirtualJoystick joystick;
    
    private Rigidbody thisRigidbody;
    public float jumpSpeed = 3f;
    public float jumpDelay = 2f;

    private bool canjump;
    private bool isjumping;
    //private Rigidbody rb;
    private float countDown;



    private void Start()
    {
        thisRigidbody = gameObject.AddComponent<Rigidbody>();
        thisRigidbody.maxAngularVelocity = terminalRotationalSpeed;
        thisRigidbody.drag = drag;

        canjump = true;
        thisRigidbody = GetComponent<Rigidbody>();
        countDown = jumpDelay;

    }
    private void Move()
    {
        thisRigidbody.AddForce(MoveVector * moveSpeed);

    }
    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;
        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();

        if (dir.magnitude > 1)
            dir.Normalize();
        return dir;
    }
    void FixedUpdate()
    {
        MoveVector = PoolInput();
        Move();


       if (isjumping && countDown > 0)
            countDown -= Time.deltaTime;
        else
        {
            canjump = true;
            isjumping = false;
            countDown = jumpDelay;
        }
    }
   
    public void StartLetsJump()
    {
        if (canjump)
        {
            canjump = false;
            isjumping = true;
            thisRigidbody.AddForce(0, jumpSpeed, 0, ForceMode.Impulse);
        }
    }
}
