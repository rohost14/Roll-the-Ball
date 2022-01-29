using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Start()
    {
        rb.velocity = Vector3.forward * speed * Time.deltaTime;
    }
}
