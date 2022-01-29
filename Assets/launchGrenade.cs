using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchGrenade : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject grenade;
    float range = 1f;
    private float lastClick = 0f;
    
    
    void Start()
    {
      
    }
    public void OnButtonCreateGame()
    {
        if (lastClick >= (Time.time - 3f)) return;
        lastClick = Time.time;
        Launch();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.C))
            Launch();
    }
    public void Launch()
    {
 
        GameObject grenadeInstance = Instantiate(grenade, spawnPoint.position, spawnPoint.rotation);
        grenadeInstance.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);
    }
}
