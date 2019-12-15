using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfisarePoint_nr_start : MonoBehaviour
{
    public Text pct_nr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pct_nr.text = " " + Informations.Points_nr;
    }
}
