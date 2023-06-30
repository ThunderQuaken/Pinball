using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class LeftFlipperRotator : MonoBehaviour
{

    public float speed;
    public Vector3 direction;
    bool rotating = false;
    Vector3 downPosition = new Vector3(0, 20, 0);
    Vector3 upPosition = new Vector3(0, 350, 0);

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.localEulerAngles.y <= 20 || transform.localEulerAngles.y > 350)
            {
                transform.Rotate(direction * speed * Time.deltaTime);
            }
        } else
        {
            if (transform.localEulerAngles.y < 20 || transform.localEulerAngles.y >= 350)
            {
                transform.Rotate(direction * speed * Time.deltaTime * -1);
            }
        }

        if (transform.localEulerAngles.y > 20 && transform.localEulerAngles.y < 170)
        {
            transform.Rotate(downPosition - transform.localEulerAngles);
        }
        if (transform.localEulerAngles.y < 350 && transform.localEulerAngles.y > 180)
        {
            transform.Rotate(upPosition - transform.localEulerAngles);
        }
    }
}
