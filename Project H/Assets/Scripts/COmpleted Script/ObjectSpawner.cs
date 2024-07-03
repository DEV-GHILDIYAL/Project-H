using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to be spawned
    public int numberOfObjects = 30; // Number of objects to spawn
    public Vector3 spawnRange = new Vector3(10f, 0f, 10f); // Range in which objects will be spawned

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 spawnPosition = transform.position + new Vector3(Random.Range(-spawnRange.x, spawnRange.x),
                                                                     Random.Range(-spawnRange.y, spawnRange.y),
                                                                     Random.Range(-spawnRange.z, spawnRange.z));
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
