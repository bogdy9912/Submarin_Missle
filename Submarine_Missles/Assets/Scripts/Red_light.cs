using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_light : MonoBehaviour
{
    // Start is called before the first frame update

    public void Red_light_active()
    {
        if (Informations.Points_nr >= 25 && Informations.color !=1)
        {
            Informations.color = 1;
            Informations.Points_nr -= 25;
        }
    }

    
}
