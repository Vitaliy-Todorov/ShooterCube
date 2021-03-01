using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 10.0F;
    private Vector3 ganPosition;
    //направление оружия
    public Vector3 Position { set { ganPosition = value; } }

    private void Start()
    {
        //Debug.Log(this.transform.parent);
        ganPosition.x = -ganPosition.x;
        ganPosition.z = -ganPosition.z;
        Destroy(gameObject, 1.4F);
    }

    private void FixedUpdate()
    {
        //движение пули
        transform.Translate(ganPosition * speed * Time.fixedDeltaTime);
    }
}
