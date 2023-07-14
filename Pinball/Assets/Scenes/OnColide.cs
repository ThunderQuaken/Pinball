using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;


public class OnCollide : MonoBehaviour
{
    bool bumperCollision = false;
    float bumperMultiplier;
    Rigidbody rb;
    ContactPoint contact;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bumper")
        {
            bumperCollision= true;
            bumperMultiplier = (float) Variables.Object(col.gameObject).Get("BumperMultiplier");
            contact = col.GetContact(0);
        }
    }

    void Update()
    {
        if (bumperCollision == true)
        {
            bumperCollision = false;
            rb.AddForce(contact.normal *  bumperMultiplier);
            ScoreManager.instance.AddPoint(200);
        }
    }
}
