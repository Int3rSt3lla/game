using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    private float nextActionTime = 0.0f;
    public float period = 0.1f;

    AudioSource audioSource;
    public AudioClip deathsound;

    public int maxHealth;
    int currentHealth;

    public Hudmanager HUD;
    public GameOverManager GameOverManager;
    
    private void Start()
    {
       currentHealth = maxHealth; 
       
       HUD.SetMaxValue(maxHealth);
       HUD.UpdateHealthBar(currentHealth);

       audioSource = GetComponent<AudioSource>();

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
    
    void Update () 
    {
        if (Time.time > nextActionTime ) 
        {
            nextActionTime += period;
        }
    }
    
    void Die()
    {
        GameOverManager.GameOver();
        audioSource.PlayOneShot(deathsound);
    }
}

