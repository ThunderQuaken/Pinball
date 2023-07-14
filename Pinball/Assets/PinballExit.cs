using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballExit : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Pinball")
        {
            Destroy(other.gameObject);
            PinballManager.instance.DestroyPinball();
        }
    }

}
