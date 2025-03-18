using UnityEngine;
using System.Collections;

public class BossCode1 : MonoBehaviour
{
    public GameObject AttackPattern;
    public GameObject AttackPattern2;

    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(5);
        AttackPattern2.SetActive(true);
        AttackPattern.SetActive(false);
    }
}