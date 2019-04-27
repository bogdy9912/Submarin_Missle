using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;            // The speed that the player will move at.
    Vector3 positionjoy;
    Vector3 movement;                   // The vector to store the direction of the player's movement.
  //  Animator anim;                      // Reference to the animator component.
    Rigidbody playerRigidbody;          // Reference to the player's rigidbody.
    public Rigidbody handlerRigidbody;          // Reference to the handler's rigidbody.
    int floorMask;                      // A layer mask so that a ray can be cast just at gameobjects on the floor layer.
    float camRayLength = 100f;   // The length of the ray from the camera into the scene.
    public Joystick jucarie;
    private float x;
    private float y;
    private Vector2 touchOrigin = -Vector2.one;

    void Awake()
    {
        // Create a layer mask for the floor layer.
        floorMask = LayerMask.GetMask("Floor");

        // Set up references.
      
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {

        transform.Translate(transform.forward * Time.deltaTime * 2.45f * 1, Space.World);
        
       
            Turning();

            
    }

    void Turning()
    {
        // Create a ray from the mouse cursor on screen in the direction of the camera.

        float k;
        k = jucarie.Horizontal * 1000;
        float v;
        v = jucarie.Vertical * 1000;
       // Debug.Log("k = " +k);
      //  Debug.Log("v = " +v);
        positionjoy.Set(k,2f,v);
        Ray camRay = Camera.main.ScreenPointToRay(positionjoy);
        // Create a RaycastHit variable to store information about what was hit by the ray.
        RaycastHit floorHit;
        if (v == 0 && k == 0)
            ;
        else
        // Perform the raycast and if it hits something on the floor layer...
        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            // Create a vector from the player to the point on the floor the raycast from the mouse hit.
           // Vector3 playerToMouse = floorHit.point - transform.position;
            Vector3 playertodirection = positionjoy - transform.position;
            // Ensure the vector is entirely along the floor plane.
            //playerToMouse.y = 0f;

            // Create a quaternion (rotation) based on looking down the vector from the player to the mouse.
            //Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            Quaternion newRotation2 = Quaternion.LookRotation(playertodirection);

            // Set the player's rotation to this new rotation.
            playerRigidbody.MoveRotation(newRotation2); // daca nu pun playerul ci pun discul?
        }
    }

}
