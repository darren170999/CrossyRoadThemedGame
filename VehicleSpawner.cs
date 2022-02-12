using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject vehicle;
    [SerializeField] private GameObject vehicle2;
    [SerializeField] private GameObject vehicle3;
    [SerializeField] private GameObject vehicle4;
    [SerializeField] private Transform spawnPos;

    [SerializeField] private float minSeparationTime;
    [SerializeField] private float maxSeparationTime;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnVehicle());
    }

    // Update is called once per frame
    private IEnumerator SpawnVehicle()
    {
        while (true)
        {
            int count = Random.Range(1, 5);
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));
            if(count == 1)
            {
                Instantiate(vehicle, spawnPos.position, Quaternion.identity);
            }
            else if(count == 2)
            {
                Instantiate(vehicle2, spawnPos.position, Quaternion.identity);
            }
            else if (count == 3)
            {
                Instantiate(vehicle3, spawnPos.position, Quaternion.identity);
            }
            else if (count == 4)
            {
                Instantiate(vehicle4, spawnPos.position, Quaternion.identity);
            }

        }
    }

}
