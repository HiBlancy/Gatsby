using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AudioManager.obj.playFish();
            PlayerLives.obj.addLive();
            gameObject.SetActive(false);
        }
    }
}
