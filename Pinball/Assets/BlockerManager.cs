using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerManager : MonoBehaviour
{

    [SerializeField] Renderer r;
    [SerializeField] Collider c;

    private void OnTriggerExit(Collider other)
    {
        r.enabled = false;
        c.isTrigger = true;
    }
}
