using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade : MonoBehaviour
{
    public GameObject explosionEffect;
    public float delay = 3f;
    public float explosionforce = 10f;
    public float radius = 20f;
   

    void Start()
    {
        Invoke("Explode", delay);
        
    }
    
    public void Explode()
    {
       
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        //Applying force
        foreach (Collider near in colliders)
        {
            Rigidbody rig = near.GetComponent<Rigidbody>();
            if (rig != null)
                rig.AddExplosionForce(explosionforce, transform.position, radius, 1f, ForceMode.Impulse);
        }
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    } 
    
}
