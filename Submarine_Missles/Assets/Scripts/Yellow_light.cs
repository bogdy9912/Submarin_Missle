using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow_light : MonoBehaviour
{
    // Start is called before the first frame update

    public void Yellow_light_active()
    {
        if (Informations.Points_nr >= 100 && Informations.color != 4)
        {
            Informations.color = 4;
            Informations.Points_nr -= 100;
        }
    }

    
}
