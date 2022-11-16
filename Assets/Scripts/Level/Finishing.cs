using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishing : MonoBehaviour
{
    [SerializeField] GameObject victoryPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("HighscoreLevel1", Game.obj.score);

            AudioManager.obj.playFish();
            gameObject.SetActive(false);

            PlayerPrefs.SetInt("SavedLevel1", 1);

            victoryPanel.SetActive(true);
            collision.gameObject.SetActive(false);
        }
    }
}