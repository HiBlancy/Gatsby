using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCollisionWithPlayer : MonoBehaviour
{
    public int giveScore = 100;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            PlayerLives.obj.TakeDamage();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Game.obj.addScore(giveScore);
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<EnemyDeath>().enabled = true;
            UIManager.obj.updateScore();
        }
    }
}
