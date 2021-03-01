using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public float horizontal;
    public float vertical;

    public void Move()
    {
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        transform.Translate(movement * speed * Time.fixedDeltaTime, Space.World);
    }
}
