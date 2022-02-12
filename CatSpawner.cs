using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform spawnPos;
    [SerializeField] private int rotationWished;


    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnCat());
    }

    // Update is called once per frame
    private IEnumerator SpawnCat()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(8,30));
            enemy = (GameObject)Instantiate(enemy, spawnPos.position, Quaternion.identity);
            enemy.transform.Rotate(new Vector3(rotationWished, rotationWished, rotationWished));
        }
    }
}
