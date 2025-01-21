using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessSpawner : MonoBehaviour



{
    public GameObject objectToSpawn;
    public Transform spawnPoint;

    public float spawnInterval = 2f;
    public float minimumSpawnInterval = 1f;
    public float intervalDecrease = 0.1f;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    IEnumerator SpawnEnemies()
    {
         while (true)
         {
            if (objectToSpawn != null && spawnPoint != null)
            {
                Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            }
            
            else
            {
                Debug.LogWarning("Object to spawn or spawn point not set");
            }

            yield return new WaitForSeconds(spawnInterval);

            spawnInterval = Mathf.Max(minimumSpawnInterval, spawnInterval - intervalDecrease);
         }
    }

}
