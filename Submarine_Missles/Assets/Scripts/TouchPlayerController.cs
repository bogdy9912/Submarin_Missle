using UnityEngine;

public class TouchPlayerController : MonoBehaviour
{
    public float copy =0;

    
    // Update is called once per frame
    void Update()
    {
        copy = MobileJoystick_UI.instance.moveDirection.y;
        copy = Mathf.Abs(copy);
        //Move Front/Back
        /* if (MobileJoystick_UI.instance.moveDirection.y != 0)
         {
             transform.Translate(transform.forward * Time.deltaTime * 2.45f * MobileJoystick_UI.instance.moveDirection.y, Space.World);
         }
         */
    
        
            transform.Translate(transform.forward * Time.deltaTime * 2.45f * 1, Space.World);
        
        //Rotate Left/Right
        if (MobileJoystick_UI.instance.moveDirection.x != 0)
        {
            transform.Translate(transform.right * Time.deltaTime * 2.45f * MobileJoystick_UI.instance.moveDirection.x, Space.World);
            if (MobileJoystick_UI.instance.moveDirection.x>0)
            transform.Rotate(new Vector3(0, 14, 0) * Time.deltaTime * 4.5f * 1, Space.Self);
            else
                transform.Rotate(new Vector3(0, 14, 0) * Time.deltaTime * 4.5f * (-1), Space.Self);
        }
    }
}