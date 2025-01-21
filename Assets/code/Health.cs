using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;
    
    private void Start()
    {
       currentHealth = maxHealth; 
       

    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        
        currentHealth -= damage;
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
