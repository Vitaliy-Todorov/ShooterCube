using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float speed = 15.0F;

    public float damege = 20.0f;

    Motion motion;

    //направление оружия
    private Vector3 ganPosition;
    public Vector3 Position { set { ganPosition = value; } }

    private void Start()
    {
        Destroy(gameObject, 1.4F);
        motion = gameObject.GetComponent<Motion>();
    }

    private void FixedUpdate()
    {
        motion.Move(ganPosition, speed);
    }
}
