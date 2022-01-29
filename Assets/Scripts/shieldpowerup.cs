using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldpowerup : MonoBehaviour
{
     //private bool isShield;
    // public float moveSpeed;
    public float timerr = 0f;
    public float seconds = 5f;
    public GameObject desshield ;
   // public GameObject shield;

    void Start()
    {
       // isShield = true;
        
    }
    private void Update()
    {
       
        timerr += Time.deltaTime;
        if(timerr>seconds)
        {
            timerr = 0;
            GameObject.Find("ShieldSphere").SetActive(false);
           
           // GetComponent<JoystickPlayerExample>().shield.SetActive(false);
            desshield.SetActive(false);
            //  shield.SetActive(false);
        }
    }
    
       public void OnTriggerEnter(Collider other)


    {
            if (other.tag == "Player")
            {


               // if (isShield)
                //{

                Chaser.minDist = 2f;
                other.GetComponent<JoystickPlayerExample>().shield.SetActive(true);

                Destroy(gameObject);
                 //}

            }

         }
    // void OnBecameInvisible()
   // {
   //     Destroy(gameObject);       
   // }
}
