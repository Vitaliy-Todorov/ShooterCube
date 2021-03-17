using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanEnemy : MonoBehaviour
{
    private Gun gun;
    private IEnumerator coroutine;

    void Start()
    {
        gun = gameObject.GetComponent<Gun>();

        ShotEnemy();
    }

    void ShotEnemy()
    {
        gun.Shot();
        Invoke("ShotEnemy", 2.4f);
    }
}
