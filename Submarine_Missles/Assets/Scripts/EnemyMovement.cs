using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMovement: MonoBehaviour
{
     GameObject ply;
    public GameObject ply2;
    Transform player;
    public Rigidbody ply_rig;
        // Reference to the player's position.
  //  PlayerHealth playerHealth;      // Reference to the player's health.
   // EnemyHealth enemyHealth;        // Reference to this enemy's health.
    public NavMeshAgent nav;               // Reference to the nav mesh agent.


    void Awake()
    {
        // Set up the references.
       
        player = GameObject.FindGameObjectWithTag("Player").transform;
        ply = GameObject.FindGameObjectWithTag("Player");
     //   playerHealth = player.GetComponent<PlayerHealth>();
     //   enemyHealth = GetComponent<EnemyHealth>();
        //nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        

          ply_rig.freezeRotation = true;
        // If the enemy and the player have health left...
        if (script.enemyHealth > 0 && script.playerHealth > 0)
        {
            // ... set the destination of the nav mesh agent to the player.

            nav.SetDestination(player.position);
            //nav.Warp(player.position);
          


            Debug.Log("AIUREA");
        }
        // Otherwise...
        else
        {
            // ... disable the nav mesh agent.
            nav.enabled = false;
        }
    }
}