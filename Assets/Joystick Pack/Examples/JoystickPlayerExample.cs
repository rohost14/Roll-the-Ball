using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public  float boostTimer;
    private  bool Boosting;
    private /*static*/ float speed = 18;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public GameObject shield;
   // public GameObject slowspeed;
   // public bool isShield;


    private void Start()
    {
        speed = 18;
        boostTimer = 0f;
        Boosting = false;
    }
    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);


        if (Boosting)
        {
            boostTimer += Time.deltaTime;
            if (boostTimer >= 7)
            {
                speed = 18;
                boostTimer = 0;
                Boosting = false;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpeedBoost")
        {
            Boosting = true;
            speed = 40;
            Destroy(other.gameObject);
        }
        else if(other.tag =="SpeedSlow")
        {
            Boosting = true;
           speed = 5;
           
            Destroy(other.gameObject);

        }
      /* else if (other.tag == "Shield")
        {
            //Boosting = true;
            if (isShield)
            {
                Boosting = true;
                Chaser.minDist = 2f;
                other.GetComponent<JoystickPlayerExample>().shield.SetActive(true);
                Boosting = true;
                Destroy(other.gameObject);
            }
        }*/
    }
}