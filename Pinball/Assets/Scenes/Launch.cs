
using UnityEngine;

public class Launch : MonoBehaviour
{

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce(-5000, 0, 0);
    }
}
