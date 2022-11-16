using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game obj;

    public int maxLives = 3;

    public int score;

    void Awake()
    {
        obj = this;
    }

    public void addScore(int giveScore)
    {
        score += giveScore;
    }

    void OnDestroy()
    {
        obj = null;
    }
}