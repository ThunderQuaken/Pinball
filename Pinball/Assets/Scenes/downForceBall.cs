using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downForceBall : MonoBehaviour
{
    Rigidbody rb;
    Vector3 force = new Vector3 (2f, 0f, 0f);


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce (force);
        Debug.Log(rb.velocity.magnitude);
        if (rb.velocity.magnitude > 150)
        {
            rb.velocity = rb.velocity * 150 / rb.velocity.magnitude;
            
        }
    }
}
