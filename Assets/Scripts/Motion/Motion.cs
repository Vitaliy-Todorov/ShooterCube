using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public void Move(Vector3 movement, float speed)
    {
        transform.Translate(movement * speed * Time.fixedDeltaTime, Space.World);
    }

    public void Teleportation(Vector3 position, Vector3 normal)
    {
        transform.position = position;
        transform.forward = normal;
    }
}
