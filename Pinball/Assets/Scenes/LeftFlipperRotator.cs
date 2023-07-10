using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class LeftFlipperRotator : MonoBehaviour
{

    public float speed;
    public Vector3 direction;
    public bool rotating = false;
    Vector3 downPosition = new Vector3(0, 20, 0);
    Vector3 upPosition = new Vector3(0, 350, 0);
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.localEulerAngles.y <= 20 || transform.localEulerAngles.y > 350)
            {
                rb.angularVelocity.Set(0f, 20f, 0f);
                Debug.Log(rb.angularVelocity);
                rotating = true;
            }
        
        } /* else
        {
            if (transform.localEulerAngles.y < 20 || transform.localEulerAngles.y >= 350)
            {
                transform.Rotate(direction * speed * Time.deltaTime * -1);
                rotating = false;
            }
        }

        if (transform.localEulerAngles.y > 20 && transform.localEulerAngles.y < 170)
        {
            transform.Rotate(downPosition - transform.localEulerAngles);
            rotating = false;
        }
        if (transform.localEulerAngles.y < 350 && transform.localEulerAngles.y > 180)
        {
            transform.Rotate(upPosition - transform.localEulerAngles);
            rotating = false;
        }
        */
    }
}
