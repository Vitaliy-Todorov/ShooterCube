using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    Bullet bullet;

    public void Shot()
    {
        Vector3 ganPosition = transform.position;
        Quaternion ganRotation = transform.localRotation;
        Bullet newBullet = Instantiate(bullet, ganPosition, ganRotation);
        newBullet.transform.parent = this.transform.parent;

        newBullet.Position = transform.forward;
    }
}
