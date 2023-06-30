using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TriggerExit : MonoBehaviour
{

    public Renderer r;
    public Collider c;

    void OnTriggerExit()
    {
        this.r.enabled = true;
        this.c.isTrigger = false;
    }
}
