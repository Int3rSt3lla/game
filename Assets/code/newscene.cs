using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newscene : MonoBehaviour
{
    public string SceneToLoad = "";

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    
    }

   
}
