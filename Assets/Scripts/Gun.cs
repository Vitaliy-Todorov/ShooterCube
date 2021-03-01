using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Bullet bullet;
    [SerializeField]
    private Cube cube;

    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space)) Shot();
    }

    private void Shot()
    {
        Vector3 ganPosition = transform.position;
        Quaternion ganRotation = transform.localRotation;
        Bullet newBullet = Instantiate(bullet, ganPosition, ganRotation);
        newBullet.transform.parent = this.transform.parent;

        newBullet.Position = transform.forward;
    }
}
