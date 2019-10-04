using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


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
        if (Informations.reclama_continuare == false)
        {
            if (Advertisement.IsReady("rewardedVideo"))
            {
                Advertisement.Show("rewardedVideo");
            }
            Informations.reclama_continuare = true;
        }
        else
        {
            Informations.reclama_continuare = false;
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