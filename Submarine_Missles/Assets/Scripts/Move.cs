using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    private float dirx, diry, speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
       // dirx = CrossPlatformInputManager.GetAxis;
    }
}
