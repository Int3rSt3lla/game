using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;

    public Hudmanager HUD;
    
    private void Start()
    {
       currentHealth = maxHealth; 
       
       HUD.SetMaxValue(maxHealth);
       HUD.UpdateHealthBar(currentHealth);

    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        
        currentHealth -= damage;

        HUD.UpdateHealthBar(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
            Debug.Log(gameObject.name + " died");
        }
        
        if (currentHealth <= 20)
        {
            Debug.LogWarning(gameObject.name + " low health");
        }

        Debug.Log(Time.time + gameObject.name + " health = " + currentHealth);
    }
    
    void Die()
    {
        Destroy(gameObject);
    }
    
}

