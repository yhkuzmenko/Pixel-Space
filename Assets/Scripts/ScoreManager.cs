using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    public static void AddOne()
    {
        score++;
    }

    public static void AddTen()
    {
        score = score += 10;
    }


    public static int GetScore()
    {
        return score;
    }

    public static void ResetScore()
    {
        score = 0;
    }
}
