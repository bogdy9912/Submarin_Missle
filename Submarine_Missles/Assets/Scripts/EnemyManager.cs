using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
           
    public GameObject enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
  //  
    public GameObject playerObj;
    GameObject firstpoint;
    GameObject secondpoint;
    GameObject thirdpoint;


    public float Timere;

    void Start()
    {
        StartCoroutine(Example());        
    }

    IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime(Timere);
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        Informations.inceput = false;
    }

    void Spawn()
    {
        // If the player has no health left...
        if (Informations.playerHealth <= 0f)
        {
            // ... exit the function.
            return;
        }

        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
     
        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}

