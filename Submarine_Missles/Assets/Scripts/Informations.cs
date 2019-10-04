using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Informations
{
    private static int highScore = 0;
    public static int currentScor = 0;
    public static int time;
    public static int timeAfterCollision;
    public static bool HitSub = false;
    public static int playerHealth = 1;
    public static int enemyHealth = 1;
    public static bool inceput = true;
    public static float timp_asteptare_inceput;
    public static float distSpw1 = Screen.height;
    public static bool inceputptrepetare=true;
    public static float Points_nr;
    public static bool canvasactive = false;
    public static bool GameOverCanvas = false;
    public static float color;
    public static float point_this_round;
    public static bool reclama_continuare = false;


    public static int High_Score
    {
        get
        {
            return highScore;
        }
        set
        {
            highScore = value;
        }
    }
}
