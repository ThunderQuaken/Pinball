using UnityEngine;

public class RightFlipperRotator : MonoBehaviour
{

    public float speed;
    public Vector3 direction;
    public bool rotating = false;
    public Rigidbody rb;
    HingeJoint joint;
    JointMotor motor;

    void Start()
    {
        joint = this.GetComponent<HingeJoint>();
        motor = joint.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            motor.force = 20000;
            motor.targetVelocity = 1000;
            rotating = true;
            joint.motor = motor;

        }
        else
        {
            motor.force = 1000;
            motor.targetVelocity =-1000;
            rotating = false;
            joint.motor = motor;
        }

    }
}