using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game obj { get; private set; }

    public int maxLives = 3;

    public int score;
    void Awake()
    {
        if (obj != null && obj != this)
            Destroy(this);
        else
            obj = this;
    }

    public void addScore(int giveScore)
    {
        score += giveScore;
    }
}
