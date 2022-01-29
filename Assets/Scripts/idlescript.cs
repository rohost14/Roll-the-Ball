using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idlescript : MonoBehaviour
{
    public Animator ani;
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player") 
        {
            ani.enabled= true;
        }
    }
 
}
