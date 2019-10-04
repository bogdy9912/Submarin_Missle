using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    
    public Text text;
    private float timer = 0.0f;
    private float timer2 = 0.0f;
    public GameObject GmOver;
    public GameObject Jy;
    public GameObject r1;
    public GameObject r2;
    public GameObject r3;
    public GameObject r4;
    public GameObject RED;
    public GameObject GREEN;
    public GameObject BLUE;
    public GameObject YELLOW;
    public Text PointTxt;
    public Text PointTxt_this_round;
    private float copie_Points_this_round;
    
    // Start is called before the first frame update
    void Start()
    {
            
        if (Informations.color == 0)
        {
            RED.SetActive(false);
            GREEN.SetActive(false);
            BLUE.SetActive(false);
            YELLOW.SetActive(false);
        }
        if (Informations.color == 1)
        {
            RED.SetActive(true);
            GREEN.SetActive(false);
            BLUE.SetActive(false);
            YELLOW.SetActive(false);
        }
        else
            if (Informations.color == 2)
        {
            RED.SetActive(false);
            GREEN.SetActive(true);
            BLUE.SetActive(false);
            YELLOW.SetActive(false);
        }
        else
            if (Informations.color == 3)
        {
            RED.SetActive(false);
            GREEN.SetActive(false);
            BLUE.SetActive(true);
            YELLOW.SetActive(false);
        }
        else
            if (Informations.color == 4)
        {
            RED.SetActive(false);
            GREEN.SetActive(false);
            BLUE.SetActive(false);
            YELLOW.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Informations.HitSub == false)
            Informations.currentScor += 1;
       
        copie_Points_this_round = Informations.point_this_round;

        timer += Time.deltaTime;
        Informations.time = (int) timer % 60;
        PointTxt.text = " " + Informations.Points_nr;
        // daca a lovit sa faca dellay
        if (Informations.HitSub == true)
        {
            if (Informations.timeAfterCollision == 1) // dellay pentru a afisa game over
            {
                
                GmOver.SetActive(true); // aici se activeaza canvas de game over
                Jy.SetActive(false);

                PointTxt_this_round.text = " " + Informations.point_this_round;

                // distrug rachetele ca sa nu se mai spawneze altele
                 Destroy(r1);
                 Destroy(r2);
                 Destroy(r3);
                 Destroy(r4);
                       
              
               // SceneManager.LoadScene(2);                
                text.text = " " + Informations.currentScor;
                Informations.HitSub = false;
               
                
            }
            else
            {
                timer2 += Time.deltaTime;
                Informations.timeAfterCollision = (int)timer2 % 60;
            }
        }
       
       

    }
     
}
