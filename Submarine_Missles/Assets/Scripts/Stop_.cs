using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stop_ : MonoBehaviour
{

    public GameObject explozie;
    public GameObject impact;
    public Text score;
    Vector3 pozitie;
    public Rigidbody jucator;
    

    
    public GameObject ExplosionEffect;
    private float detonationTime = 3f;
    private float bombTimer;
    private int intermediar;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {

        bombTimer += Time.deltaTime;
        intermediar = (int)bombTimer % 60;
    }
  
 
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Micro_Sub")
        {
            pozitie = impact.transform.position;

            // pune pauza ca sa dea continue la joc

            explozie.transform.position = pozitie;
            explozie.SetActive(true); // activeaza explozia

            

            if (Informations.reclama_continuare == true)
            {
                    jucator.detectCollisions = false;
                if (intermediar >= detonationTime)
                    jucator.detectCollisions = true;               
                
                
            }

            // if (Informations.HitSub == false ) // testeaza daca a lovit sau nu 
            //{
            Destroy(col.gameObject);
                Destroy(transform.gameObject);
            //}




            Informations.HitSub = true; // a lovit submarinul
           
            if (Informations.currentScor > Informations.High_Score) //seteaza high score
            {
                Informations.High_Score = Informations.currentScor;
            }
            Informations.canvasactive = true;
            Informations.GameOverCanvas = true;     
            Debug.Log(Informations.High_Score);
        }
       
           if (col.gameObject.name == "Racheta1(Clone)")
           {   

               pozitie = impact.transform.position;
               explozie.transform.position = pozitie;
              
              
               
               Instantiate(ExplosionEffect, transform.position, transform.rotation);
              
               Destroy(col.gameObject);  // se distrug 2 clone la asta..?! why?
               Destroy(transform.gameObject);
            if (Informations.HitSub == false && Informations.canvasactive == false)
            {
                Informations.Points_nr += 1;
                Informations.point_this_round += 1;
            }

           }
           if (col.gameObject.name == "Racheta2(Clone)")
           {   
               pozitie = impact.transform.position;
               explozie.transform.position = pozitie;
              
               Instantiate(ExplosionEffect, transform.position, transform.rotation);
               Destroy(col.gameObject);  // se distrug 2 clone la asta..?! why?
               Destroy(transform.gameObject);
            if (Informations.HitSub == false && Informations.canvasactive == false)
            {
                Informations.Points_nr += 1;
                Informations.point_this_round += 1;
            }
        }
           if (col.gameObject.name == "Racheta3(Clone)")
           {   
               pozitie = impact.transform.position;
               explozie.transform.position = pozitie;
               
               Instantiate(ExplosionEffect, transform.position, transform.rotation);
               Destroy(col.gameObject);  // se distrug 2 clone la asta..?! why?
               Destroy(transform.gameObject);
            if (Informations.HitSub == false && Informations.canvasactive == false)
            {
                Informations.Points_nr += 1;
                Informations.point_this_round += 1;
            }
        }
        if (col.gameObject.name == "Racheta4(Clone)")
        {
            pozitie = impact.transform.position;
            explozie.transform.position = pozitie;

            Instantiate(ExplosionEffect, transform.position, transform.rotation);
            Destroy(col.gameObject);  // se distrug 2 clone la asta..?! why?
            Destroy(transform.gameObject);
            if (Informations.HitSub == false && Informations.canvasactive == false)
            {
                Informations.Points_nr += 1;
                Informations.point_this_round += 1;
            }
        }


    }

    
}
