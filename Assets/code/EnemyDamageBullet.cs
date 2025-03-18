using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageBullet : MonoBehaviour
{
    public int damage;
    public GameObject Bullet;

    void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>()?.TakeDamage(damage);
            Destroy (Bullet);
        }
   }
    // Start is called before the first frame update
    
}

