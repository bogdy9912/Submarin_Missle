using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchToPlay : MonoBehaviour
{
    Button touch_to_play;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (script.playerHealth<=0)
        {
            anim.SetTrigger("GameOver");
        }
        
    }
    public void Click_pe_button()
    {
        Application.LoadLevel(Application.loadedLevel);

    }
}
