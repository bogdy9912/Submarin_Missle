using UnityEngine;
using System.Collections;
public class Player_move : MonoBehaviour
{
    public float moveSpeed ;
    public VJHandler jsMovement;

    private Vector3 direction;
    private float xMin, xMax, yMin, yMax;
    Rigidbody playerRigidbody;  
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {

        direction = jsMovement.InputDirection; //InputDirection can be used as per the need of your project
        float x, y;
        x = direction.x;
        y = direction.y;
        if (direction.magnitude != 0)
        {

            transform.position += direction * moveSpeed;
            Quaternion newRotation2 = Quaternion.LookRotation(direction);
            playerRigidbody.MoveRotation(newRotation2);
            
        }
       
    }

   
}