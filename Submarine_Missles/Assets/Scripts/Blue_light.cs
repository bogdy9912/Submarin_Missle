using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_light : MonoBehaviour
{
    // Start is called before the first frame update

    public void Blue_light_active()
    {
        if (Informations.Points_nr >= 50 && Informations.color != 3)
        {
            Informations.color = 3;
            Informations.Points_nr -= 50;
        }
    }

    
}
