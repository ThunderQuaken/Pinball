using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;


public class OnCollide : MonoBehaviour
{

    bool bumperCircleCollision = false;
    bool bumperTriangleCollision = false;
    float bumperMultiplier;
    public Rigidbody rb;
    public Vector3 posDif;
    ContactPoint contact;
    Vector3 radius = new Vector3(0.0f, 0.9f, 0.0f);


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
    }

    void Update()
    {
        if (bumperCircleCollision == true)
        {
            bumperCircleCollision = false;
            rb.AddForce(posDif * bumperMultiplier);
            ScoreManager.instance.AddPoint(200);
        }

        if (bumperTriangleCollision == true)
        {
            bumperTriangleCollision = false;
            rb.AddForce(contact.normal *  bumperMultiplier);
            ScoreManager.instance.AddPoint(200);
        }
    }
}
