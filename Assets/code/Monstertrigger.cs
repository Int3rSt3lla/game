using UnityEngine;

public class Monstertrigger : MonoBehaviour
{
    public GameObject hiddendoor;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            hiddendoor.SetActive(false);
        }
    
    }

   
}