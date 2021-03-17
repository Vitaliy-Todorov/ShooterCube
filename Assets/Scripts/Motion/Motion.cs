using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    protected DataStorageShootingCube data;

    public void Move(Vector3 movement, float speed)
    {
        transform.Translate(movement * speed * Time.fixedDeltaTime, Space.World);
    }

    //коментарий
    public void Teleportation(Vector3 positionTeleportation, Vector3 normalTeleportation)
    {
        transform.position = positionTeleportation;
        transform.forward = normalTeleportation;
    }

    public void SavePosition()
    {
        data.CurrentPosition = transform.position;
        data.CurrentNormal = transform.forward;
    }

    public void LoadPosition()
    {
        transform.position = data.CurrentPosition;
        transform.forward = data.CurrentNormal;
    }
}
