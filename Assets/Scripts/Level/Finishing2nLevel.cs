using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishing2nLevel : MonoBehaviour
{
    [SerializeField] GameObject victoryPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("HighscoreLevel2", Game.obj.score);

            AudioManager.obj.playFish();
            gameObject.SetActive(false);

            PlayerPrefs.SetInt("SavedLevel2", 1);

            victoryPanel.SetActive(true);
            collision.gameObject.SetActive(false);
        }
    }
}