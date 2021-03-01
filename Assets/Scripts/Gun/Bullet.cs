using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 10.0F;
    public float damege = 20;

    //направление оружия
    private Vector3 ganPosition;
    public Vector3 Position { set { ganPosition = value; } }

    private void Start()
    {
        Destroy(gameObject, 1.4F);
    }

    private void FixedUpdate()
    {
        //движение пули
        transform.Translate(ganPosition * speed * Time.fixedDeltaTime);
    }
}
