using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public float currentHealth = 100;
    public HealthBar healthBar;

    private void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
    }
}
