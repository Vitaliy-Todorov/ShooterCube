using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public float currentHealth;
    public HealthBar healthBar;

    [SerializeField]
    [Range(1, 5)]
    int armor = 1;
    [SerializeField]
    GameObject GmObjArmorPaint;

    public CharecterSaveData saveData;

    private void Start()
    {
        if(saveData.Death)
            Destroy(transform.root.gameObject);

        currentHealth = saveData.CurrentHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);

        if (GmObjArmorPaint != null)
        {
            float minusColorG = 250f / 255f - armor / 5f;
            GmObjArmorPaint.GetComponent<Renderer>().material.color = new Color(255f / 255f, minusColorG, 50f / 255f, 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Bullet bullet = other.GetComponent<Bullet>();

        if ((other.transform.root != transform.root) && bullet)
        {
            currentHealth -= bullet.damege / armor;
            healthBar.SetHealth(currentHealth);
            saveData.CurrentHealth = currentHealth;
            Destroy(other.gameObject);

            if (currentHealth <= 0)
            {
                Destroy(transform.root.gameObject);
                saveData.Death = true;
            }
        }
    }
}
