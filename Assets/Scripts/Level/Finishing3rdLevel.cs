using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishing3rdLevel : MonoBehaviour
{
    [SerializeField] GameObject victoryPanel;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("HighscoreLevel3", Game.obj.score);

            AudioManager.obj.playFish();
            gameObject.SetActive(false);

            victoryPanel.SetActive(true);
            collision.gameObject.SetActive(false);
        }
    }
}