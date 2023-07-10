using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downForceBall : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 force = new Vector3 (2f, 0f, 0f);

    // Update is called once per frame
    void Update()
    {
        rb.AddForce (force);
    }
}
