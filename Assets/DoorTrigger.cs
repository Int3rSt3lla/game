
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject hiddendoor;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            hiddendoor.SetActive(false);
        }
    
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            hiddendoor.SetActive(true);
        }
    
    }
}
