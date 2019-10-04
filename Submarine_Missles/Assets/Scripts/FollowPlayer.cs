using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowPlayer : MonoBehaviour
{
    //place this script on the player gameobject

    public GameObject followingPlayer; // in the inspector drag the gameobject the will be following the player to this field
    public int followDistance;
    private List<Vector3> storedPositions;
    private Rigidbody RachetaRigidbody;
    public Transform mTarget;
    public GameObject racheta_nume1;
    public int ok;
    public float mSpeed;
    private bool check = false;

    void Awake()
    {
        followingPlayer = GameObject.FindGameObjectWithTag("Player");
        storedPositions = new List<Vector3>(); //create a blank list

        if (!followingPlayer)
        {
            Debug.Log("The FollowingMe gameobject was not set");
        }

        if (followDistance == 0)
        {
            Debug.Log("Please set distance higher then 0");
        }
    }

    void Start()
    {
        RachetaRigidbody = GetComponent<Rigidbody>();
        transform.Rotate(0f, 0f, 0f);
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime(1);
        check = true;
    }

    void Update()
    {
        storedPositions.Add(followingPlayer.transform.position); //store the position every frame
        transform.LookAt(mTarget.position);
        if (ok == 1)
            transform.Rotate(0f, 90f, 0f);
        if (ok == 2)
            transform.Rotate(0f, 0f, 0f);

        if (check == true && Informations.inceput == false && racheta_nume1.name=="Racheta1(Clone)" )
        {
            transform.position = storedPositions[0]; //move the player
            storedPositions.RemoveAt(0); //delete the position that player just move to
        }
    }
}