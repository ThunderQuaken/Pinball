using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;


public class OnCollide : MonoBehaviour
{

    bool bumperCircleCollision = false;
    bool bumperTriangleCollision = false;
    bool flipperCollision = false;
    float bumperMultiplier;
    Vector3 appliedForce;
    public Rigidbody rb;
    public Vector3 posDif;
    ContactPoint contact;
    Vector3 leftFlipperBasePos;
    Vector3 rightFlipperBasePos;
    Vector3 radius = new Vector3(0.0f, 0.9f, 0.0f);


    void Start()
    {
        leftFlipperBasePos = GameObject.FindWithTag("LeftFlipperBase").transform.position;
        rightFlipperBasePos = GameObject.FindWithTag("RightFlipperBase").transform.position;
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "CircleBumper")
        {
            bumperCircleCollision = true;
            bumperMultiplier = (float) Variables.Object(col.gameObject).Get("BumperMultiplier");
            posDif = this.transform.position - col.transform.position;
        }

        if (col.gameObject.tag == "TriangleBumper")
        {
            bumperTriangleCollision= true;
            bumperMultiplier = (float)Variables.Object(col.gameObject).Get("BumperMultiplier");
            contact = col.GetContact(0);
        }

        if (col.gameObject.tag == "LeftFlipper" && col.gameObject.GetComponentInParent<LeftFlipperRotator>().rotating)
        {
            flipperCollision = true;
            contact = col.GetContact(0);

            appliedForce = this.transform.position - leftFlipperBasePos - radius;

        }

        if (col.gameObject.tag == "RightFlipper" && col.gameObject.GetComponentInParent<RightFlipperRotator>().rotating)
        {
            flipperCollision = true;
            contact = col.GetContact(0);

            appliedForce = this.transform.position - rightFlipperBasePos - radius;

        }
    }

    void Update()
    {
        if (bumperCircleCollision == true)
        {
            bumperCircleCollision = false;
            rb.AddForce(posDif * bumperMultiplier);

        }

        if (bumperTriangleCollision == true)
        {
            bumperTriangleCollision = false;
            rb.AddForce(contact.normal *  bumperMultiplier);
        }

/*        if (flipperCollision == true)
        {
            Debug.Log(contact.normal * appliedForce.y * 100);
            flipperCollision = false;
            rb.AddForce(contact.normal * appliedForce.y * 10000);
        } */
    }
}
