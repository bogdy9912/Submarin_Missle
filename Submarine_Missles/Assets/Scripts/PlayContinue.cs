using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayContinue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Continua() {
        // Informations.canvasactive = false;
        if (Informations.continue_verif == true)
        {
            Informations.continue_verif = false;
            SceneManager.LoadScene(1);
        }
    }
}
