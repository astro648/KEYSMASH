using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] virusPrefabs;
    public Vector3 spawnPosition;
    public float spawnDelay = 2.0f;
    public float spawnInterval = 3.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVirus", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnVirus()
    {
        // once multiple viruses are added, the virus spawned will be dependent on difficulty, how many viruses beat, and what viruses are in the scene at the moment
        // for now, it's random
        int virusIndex = Random.Range(0, virusPrefabs.Length);
        Instantiate(virusPrefabs[virusIndex], spawnPosition, virusPrefabs[virusIndex].transform.rotation);
    }
}
