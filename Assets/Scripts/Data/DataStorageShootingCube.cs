using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nwe Charecter Save Data", menuName = "Charecter/Data", order = 1)]
public class DataStorageShootingCube : ScriptableObject
{
    [Header("Stats")]

    [SerializeField]
    Vector3 position;
    [SerializeField]
    Vector3 normal;

    [SerializeField]
    float currentHealth;

    [SerializeField] 
    bool death;

    public float CurrentHealth
    {
        set { currentHealth = value; }
        get { return currentHealth; }
    }

    public bool Death
    {
        set { death = value; }
        get { return death; }
    }

    public Vector3 CurrentPosition
    {
        set { position = value; }
        get { return position; }
    }

    public Vector3 CurrentNormal
    {
        set { normal = value; }
        get { return normal; }
    }
}
