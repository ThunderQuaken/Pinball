using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class RightFlipperRotator : MonoBehaviour
{

    public float speed;
    public Vector3 direction;
    public bool rotating = false;
    Vector3 downPosition = new Vector3(0, 340, 0);
    Vector3 upPosition = new Vector3(0, 10, 0);

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.localEulerAngles.y >= 340 || transform.localEulerAngles.y < 10)
            {
                transform.Rotate(direction * speed * Time.deltaTime);
            }
        }
        else
        {
            if (transform.localEulerAngles.y > 340 || transform.localEulerAngles.y <= 10)
            {
                transform.Rotate(direction * speed * Time.deltaTime * -1);
            }
        }

        if (transform.localEulerAngles.y < 340 && transform.localEulerAngles.y > 170)
        {
            transform.Rotate(downPosition - transform.localEulerAngles);
        }
        if (transform.localEulerAngles.y > 10 && transform.localEulerAngles.y < 160)
        {
            transform.Rotate(upPosition - transform.localEulerAngles);
        }
    }
}