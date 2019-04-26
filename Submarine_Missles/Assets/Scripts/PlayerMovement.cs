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
       // anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {

        transform.Translate(transform.forward * Time.deltaTime * 2.45f * 1, Space.World);
        
        //  int horizontal = 0;     //Used to store the horizontal move direction.
        //  int vertical = 0;       //Used to store the vertical move direction.
        // Store the input axes.
        // float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");
        // float x ;
        //Debug.Log("h= " + h);
        //Debug.Log("v= " + v);
        // Move the player around the scene.

            //    Move(h, v);

            // Turn the player to face the mouse cursor.
            Turning();

            // Animate the player.
            //      Animating(h, v);

            //  int horizontal = 0;     //Used to store the horizontal move direction.
            //  int vertical = 0;       //Used to store the vertical move direction.
            // functie(horizontal,vertical);
            // Debug.Log("vertical = " + vertical);
    }

  /*  void Move(float h, float v)
    {
        // Set the movement vector based on the axis input.
        movement.Set(h, 0f, v);

        // Normalise the movement vector and make it proportional to the speed per second.
        movement = movement.normalized * speed * Time.deltaTime;

        // Move the player to it's current position plus the movement.
        playerRigidbody.MovePosition(transform.position + movement);
    }*/
   /* void intoarcere()
    {
        Vector3 playerToMouse = floorHit.point - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
    }*/

   /* void habar_nu_am()
    {

        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
        {
            MobileButtonsCheck(new Vector2(touch.position.x, Screen.height
    - touch.position.y), touch.fingerId);
        }

        if (touch.phase == TouchPhase.Moved)
        {
            if (moveTouch.isActive && moveTouch.touchID == touch.fingerId)
            {
                moveTouch.currentTouchPos = touch.position;
            }
        }

        if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
        {
            MobileButtonStop(touch.fingerId);
        }
    }
}*/
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

//    void Animating(float h, float v)
//    {
 //       // Create a boolean that is true if either of the input axes is non-zero.
  //      bool walking = h != 0f || v != 0f;
  //
        // Tell the animator whether or not the player is walking.
   //     anim.SetBool("IsWalking", walking);
    //}
   /* void functie(int horizontal, int vertical)
    {
        Debug.Log("Intra in functie");
        if (Input.touchCount > 0)
        {
            Debug.Log("Este in If");
            //Store the first touch detected.
            Touch myTouch = Input.touches[0];

            //Check if the phase of that touch equals Began
            if (myTouch.phase == TouchPhase.Began)
            {
                //If so, set touchOrigin to the position of that touch
                touchOrigin = myTouch.position;
            }

            //If the touch phase is not Began, and instead is equal to Ended and the x of touchOrigin is greater or equal to zero:
            else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
            {
                //Set touchEnd to equal the position of this touch
                Vector2 touchEnd = myTouch.position;

                //Calculate the difference between the beginning and end of the touch on the x axis.
                float x = touchEnd.x - touchOrigin.x;

                //Calculate the difference between the beginning and end of the touch on the y axis.
                float y = touchEnd.y - touchOrigin.y;

                //Set touchOrigin.x to -1 so that our else if statement will evaluate false and not repeat immediately.
                touchOrigin.x = -1;
                Debug.Log(x);
                Debug.Log(y);
                //Check if the difference along the x axis is greater than the difference along the y axis.
                if (Mathf.Abs(x) > Mathf.Abs(y))
                    //If x is greater than zero, set horizontal to 1, otherwise set it to -1
                    horizontal = x > 0 ? 1 : -1;
                else
                    //If y is greater than zero, set horizontal to 1, otherwise set it to -1
                    vertical = y > 0 ? 1 : -1;
            }
        }
    }*/
  /*  void idk()
    {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            Debug.Log("Nu esti fraier");
            Touch myTouch = Input.GetTouch(i);
            if (myTouch.phase == TouchPhase.Began)
            {
                //If so, set touchOrigin to the position of that touch
                touchOrigin = myTouch.position;
            }
            //If the touch phase is not Began, and instead is equal to Ended and the x of touchOrigin is greater or equal to zero:
            else if (myTouch.phase == TouchPhase.Moved && touchOrigin.x >= 0)
            {
                //Set touchEnd to equal the position of this touch
                Vector2 touchEnd = myTouch.position;

                //Calculate the difference between the beginning and end of the touch on the x axis.
                 x = touchEnd.x - touchOrigin.x;

                //Calculate the difference between the beginning and end of the touch on the y axis.
                 y = touchEnd.y - touchOrigin.y;

                //Set touchOrigin.x to -1 so that our else if statement will evaluate false and not repeat immediately.
                touchOrigin.x = -1;
                Debug.Log(x);
                Debug.Log(y);
                //Check if the difference along the x axis is greater than the difference along the y axis.
                if (Mathf.Abs(x) > Mathf.Abs(y))
                    //If x is greater than zero, set horizontal to 1, otherwise set it to -1
                    //horizontal = x > 0 ? 1 : -1;
                else
                    //If y is greater than zero, set horizontal to 1, otherwise set it to -1
                    //vertical = y > 0 ? 1 : -1;
            }
        }
    }*/
}
