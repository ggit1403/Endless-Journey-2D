using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float minX, maxX, minY, maxY;
    public float spawnBetweenTime;
    private float timeSpawn;

    void Update()
    {
        if(Time.time > timeSpawn)
        {
            Spawn();
            timeSpawn = Time.time + spawnBetweenTime;
        }
    }

     void Spawn()
     {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
     }
}
