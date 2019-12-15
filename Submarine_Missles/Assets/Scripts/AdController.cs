using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class AdController : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {

    }

    public void reclame_video()
    {


        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
        

    }
    public void reclame_rewardedVideo_GameOver()
    {
        if (Informations.continue_verif == true)
        {
            Informations.continue_verif = false;
           

            if (Informations.reclama_continuare == false)
            {
                if (Advertisement.IsReady("rewardedVideo"))
                {
                    var options = new ShowOptions { resultCallback = HandleShowResult };
                    Advertisement.Show("rewardedVideo", options);

                }
                Informations.reclama_continuare = true;
            }
            else
            {
                Informations.reclama_continuare = false;
            }
        }
    }
    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                //
                // YOUR CODE TO REWARD THE GAMER
                // Give coins etc.
                Informations.canvasactive = false;
               
                    
                    SceneManager.LoadScene(1);
                
                //Informations.verif = false;


                break;
        }
    }

    public void reclame_rewardedVideo_Bonus()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
        }
    }

    public void reclame_Banner()
    {
        if (Advertisement.IsReady("Banner"))
        {
            Advertisement.Show("Banner");
        }
    }
    // Update is called once per frame
    public void Update()
    {
       
    }
}