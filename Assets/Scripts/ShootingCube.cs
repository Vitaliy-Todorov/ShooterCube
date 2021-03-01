using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingCube : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    private void FixedUpdate()
    {
        Motion.HorizontalVertical(transform, speed);
    }
}
