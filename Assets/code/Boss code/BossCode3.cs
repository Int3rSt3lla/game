using UnityEngine;
using System.Collections;

public class BossCode3 : MonoBehaviour
{
    public GameObject AttackPattern;
    

    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(5);
        
        AttackPattern.SetActive(true);
    }
}