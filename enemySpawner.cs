using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    // Biomes enum
    public enum Biomes { Universe1, Universe2};

    [Header("Main Settings")]
    public float spawnDelay;
    public Biomes currentBiome;

    [Header("Obstacle settings")]
    public GameObject[] Universe1;
    public GameObject[] Universe2;

    // Private variables
    private Vector3 spawnPos;

    // Called at the start
    void Start()
    {

   
     

        // Initialize a spawn delay
        spawnDelay = Random.Range(.7f, 2f);

        // Spawn the first obstacle
        Invoke("SpawnObstacle", spawnDelay);
    }

    private void Update()
    {
        spawnPos = transform.position; // Set the spawn pos to update every frame allowing the slider to move(for the broken 'slideSpawner' script)
        // Kept this in as an example although it is more performance heavy than just having it set at the beginning with no pay off until the slide spawner works. 
    }

    // Spawn obstacle
    private void SpawnObstacle() 
    {

        // Run code based on biome
        switch (currentBiome)
        {
            // If current biome is grass then
            case Biomes.Universe1:
                int pickObstacle = Random.Range(0, Universe1.Length);
                GameObject tmp = Instantiate(Universe1[pickObstacle], spawnPos, Quaternion.identity);
                Destroy(tmp, 6f);
                break;

            // If current biome is sand then
            case Biomes.Universe2:
                pickObstacle = Random.Range(0, Universe2.Length);
                tmp = Instantiate(Universe2[pickObstacle], spawnPos, Quaternion.identity);
                Destroy(tmp, 6f);
                break;
        }

        // Change the spawnDelay and spawn another object
        spawnDelay = Random.Range(.7f, 2f);
        Invoke("SpawnObstacle", spawnDelay);
    }
}
