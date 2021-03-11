using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunInput : MonoBehaviour
{
    private Gun gun;

    private void Start()
    {
        gun = gameObject.GetComponent<Gun>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            gun.Shot();
    }
}
