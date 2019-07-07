using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EM_TRY : MonoBehaviour
{
   
       
    public GameObject[] enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.

    public PlayerHealth playerHealth;

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        //InvokeRepeating("Spawn", spawnTime, spawnTime);

    }


    void Spawn()
    {
        /*if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        }
        */

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);


        Instantiate(enemy[Random.Range(0, enemy.Length)], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        ObjectPuller.Instance.SpawnFromPool("Enemy", spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        // Debug.Log(enemy[Random.Range(0, enemy.Length)]);
    }
}
