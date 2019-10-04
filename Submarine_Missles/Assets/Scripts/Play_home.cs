using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_home : MonoBehaviour
{
    public void PlayHome()
    {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene(0);

        if (Informations.GameOverCanvas == true)
        {

            Informations.GameOverCanvas = false;

        }
    }
}
