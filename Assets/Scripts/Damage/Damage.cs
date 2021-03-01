using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Bullet bullet = gameObject.GetComponent<Bullet>();
        Health health = other.gameObject.GetComponentInParent<Health>();
        TakeDamage takeDamage = other.gameObject.GetComponent<TakeDamage>();

        if ((other.transform.root != transform.root) && takeDamage)
        {
            health.currentHealth -= bullet.damege / takeDamage.armor;
            health.healthBar.SetHealth(health.currentHealth);
            Destroy(gameObject);

            if (health.currentHealth <= 0) Destroy(other.transform.root.gameObject);
        }
    }
}
