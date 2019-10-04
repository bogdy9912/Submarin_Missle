using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_pause : MonoBehaviour
{
    public static bool Game_paused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if( Input.GetKeyDown(KeyCode.Escape))
        {
            if (Game_paused == true)
                Resume();
            else
                Pause();

        }
    }

    void Resume()
    {
        Time.timeScale = 1f;
    }

    void Pause()
    {
        Time.timeScale = 0f;
        Game_paused = true;
    }
}
