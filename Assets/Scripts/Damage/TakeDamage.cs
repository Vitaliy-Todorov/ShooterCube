using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    [Range(1, 5)]
    public int armor;

    private void Update()
    {
        float minusColorG = 250f / 255f - armor / 5f;
        transform.root.GetChild(1).GetChild(0).GetComponent<Renderer>().material.color = new Color(255f / 255f, minusColorG, 50f / 255f, 1);
    }

    private void Start()
    {}
}
