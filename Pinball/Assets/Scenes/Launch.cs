
using UnityEngine;

public class Launch : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(-5000, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
