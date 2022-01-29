using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseragain : MonoBehaviour
{
    public GameObject player;
  


    // Update is called once per frame
    void Update()
    {
       Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 2 * Time.deltaTime);
        transform.position += transform.forward * 5f * Time.deltaTime;
        
    }

}
