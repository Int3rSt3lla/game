using UnityEngine;

public class EnemyRange : MonoBehaviour
{
    public GameObject BasicEnemy;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            BasicEnemy.SetActive(true);
        }
    
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            BasicEnemy.SetActive(false);
        }
    
    }
}