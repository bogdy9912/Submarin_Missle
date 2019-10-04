using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAGAIN : MonoBehaviour
{    
    public void PlayAgn()
    {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        if (Informations.canvasactive == true)
        {

            Informations.canvasactive = false;
            Informations.point_this_round = 0;

        }
    }   
    
    
}
