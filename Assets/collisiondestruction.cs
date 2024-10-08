using UnityEngine;

public class collisiondestruction : MonoBehaviour
{
    void OnocllisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision detected.");
            Destroy(gameObject);
        }
    }
}
