using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfisareScor : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         score.text = "" + Informations.High_Score;
        
    }
}
