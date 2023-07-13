using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BumperCollision : MonoBehaviour
{
    [SerializeField] AnimationCurve curve;
    [SerializeField] float glowMultiplier;
    MeshRenderer meshRenderer;
    bool flash;
    float progress;
    float animLength = 1f;
    float progressPercent;

    Material oldMaterial;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = this.GetComponentInChildren<MeshRenderer>();
        oldMaterial = meshRenderer.material;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Pinball")
        {
            flash = true;
            progress = 0f;
            Debug.Log("hit");
        }
    }

    private void Update()
    {
        if (flash)
        {
            progress += Time.deltaTime;
            progressPercent = progress / animLength;

            if (progress > animLength)
            {
                progress = 0f;
                progressPercent = 1f;
                flash = false;
            }

            meshRenderer.material.SetColor("_EmissionColor", Color.red * curve.Evaluate(progressPercent) * glowMultiplier);
        }
    }
}
