using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawn : MonoBehaviour
{
    [SerializeField] private GameObject Log;
    [SerializeField] private Transform spawnPos;

    [SerializeField] private float minSeparationTime;
    [SerializeField] private float maxSeparationTime;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnLog());
    }

    // Update is called once per frame
    private IEnumerator SpawnLog()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));
            Instantiate(Log, spawnPos.position, Quaternion.identity);
            
        }
    }
}
