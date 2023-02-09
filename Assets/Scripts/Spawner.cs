using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float minSpawnTime = 3f;
    public float maxSpawnTime = 4f;

    private void Start()
    {
        Spawn();    
    }

    private void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnTime, maxSpawnTime));
    }
}
