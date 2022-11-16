using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager obj;

    [SerializeField] Text livesOnScreen;
    [SerializeField] Text scoreOnScreen;

    void Awake()
    {
        obj = this;
    }

    public void updateLives()
    {
        livesOnScreen.text = "" + PlayerLives.obj.lives;
    }

    public void updateScore()
    {
        scoreOnScreen.text = "" + Game.obj.score;
    }

    void OnDestroy()
    {
        obj = null;
    }
}
