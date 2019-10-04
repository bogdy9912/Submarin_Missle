using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_light : MonoBehaviour
{
    // Start is called before the first frame update

    public void Green_light_active()
    {
        if (Informations.Points_nr >= 40 && Informations.color != 2)
        {
            Informations.color = 2;
            Informations.Points_nr -= 40;
        }
    }

    
}
