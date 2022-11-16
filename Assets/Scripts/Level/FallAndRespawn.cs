using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallAndRespawn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            PlayerLives.obj.TakeDamage();
            PlayerMovement.obj.StartPosition();
        }
    }
}