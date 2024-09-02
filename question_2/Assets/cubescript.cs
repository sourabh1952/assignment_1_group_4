using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescript : MonoBehaviour
{
    public GameObject cubePrefab; // Reference to the cube prefab
    public int numberOfCubes = 5; // Number of cubes to spawn
    public float spawnRange = 10f; // Range within which cubes will be spawned
    void Start()
    {
        SpawnCubes();
    }
    void SpawnCubes()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            // Generate a random position
            Vector3 randomPosition = new Vector3(
                Random.Range(-spawnRange, spawnRange),
                Random.Range(-spawnRange, spawnRange),
                Random.Range(-spawnRange, spawnRange)
            );

            // Instantiate the cube at the random position
            Instantiate(cubePrefab, randomPosition, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
