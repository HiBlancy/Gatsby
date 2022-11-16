using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleFishPoints : MonoBehaviour
{
    public int giveScore = 300;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Game.obj.addScore(giveScore);
            AudioManager.obj.playFish();
            gameObject.SetActive(false);

            UIManager.obj.updateScore();
        }
    }
}