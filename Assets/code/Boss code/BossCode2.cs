using UnityEngine;
using System.Collections;

public class BossCode2 : MonoBehaviour
{
    public GameObject AttackPattern;
    public GameObject AttackPattern2;
    public GameObject AttackPattern3;
    public GameObject AttackPattern4;
    public GameObject AttackPattern5;
    public GameObject AttackPattern6;
    public GameObject AttackPattern7;

    void OnEnable()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(5);  
        AttackPattern.SetActive(false);
        AttackPattern2.SetActive(true);
        AttackPattern3.SetActive(true);
        AttackPattern4.SetActive(true);
        AttackPattern5.SetActive(true);
        AttackPattern6.SetActive(true);
        AttackPattern7.SetActive(true);
    
    }
}