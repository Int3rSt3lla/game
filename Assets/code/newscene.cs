using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newscene : MonoBehaviour
{
    public string SceneToLoad = "";
    public GameObject FinishLevel;

    

   
        void OnTriggerEnter2D (Collider2D collider) 
        {
            StartCoroutine(Delay()); 
            FinishLevel.SetActive(true);
        }

        IEnumerator Delay()
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(SceneToLoad);
            Debug.Log("Something");
        }
        
    
}   

               
        