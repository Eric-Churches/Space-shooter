using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    //spawn game objects every 5 seconds
    // create coroutine of type IEnumerator -- Yield Events
    // while loop run as long some condition is true.
    IEnumerator SpawnRoutine()
    {

        // while loop (infinite loop)
        //instantiate enemy prefab
        //yield wait for 5 seconds

        while (true)
        {
            var posToSpawn = new Vector3(Random.Range(-8, 8), 7, 0);
            Instantiate(enemyPrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }




    }
}
