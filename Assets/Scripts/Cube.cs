using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void FixedUpdate()
    {
        Motion.HorizontalVertical(transform, speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        /*Debug.Log("this: " + this);
        Debug.Log("other.transform.parent: " + other.transform.parent);
        Debug.Log(other.transform.parent == this);*/
        Debug.Log("other: " + other);
        Debug.Log("other.GetType(): " + other.GetType());
        Debug.Log(other is Bullet);
        if ((other.transform.parent == this) && other.CompareTag("Bullet"))
        {
            TakeDamage(20);

            if (currentHealth == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void TakeDamage(int damege)
    {
        currentHealth -= damege;
        healthBar.SetHealth(currentHealth);
    }
}
