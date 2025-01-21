using UnityEngine;

public class collisiondestruction : MonoBehaviour
{
    public int damage = 5;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            return;

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collision detected.");
            collision.gameObject.GetComponent<Health>()?.TakeDamage(damage); 
        }

        Destroy(gameObject);

    }
}
