using UnityEngine;

public class WaypointDisabler : MonoBehaviour
{
    public GameObject hiddendoor;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            hiddendoor.SetActive(false);
        }
    
    }

   
}