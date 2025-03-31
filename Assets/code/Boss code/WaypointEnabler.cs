using UnityEngine;

public class WaypointEnabler : MonoBehaviour
{
    public GameObject hiddendoor;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            hiddendoor.SetActive(true);
        }
    
    }

   
}