using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_missle_lookAt : MonoBehaviour
{
    public Transform mTarget;
    public float mSpeed ;
    const float EPSILON = 0.1f;
    public int ok;
    
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0f,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(mTarget.position);
        if ((transform.position - mTarget.position).magnitude > EPSILON)
            transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
        if (ok==1)
        transform.Rotate(0f, 90f, 180f);
        if(ok==2)
            transform.Rotate(0f, 0f, 0f);
        if (ok == 3)
            transform.Rotate(0f, 0f, 90f);
        
    }
}
