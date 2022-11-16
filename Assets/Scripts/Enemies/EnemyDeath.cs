using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Start()
    {
        AudioManager.obj.playEnemyHit();
        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        animator.SetTrigger("Death");
        StartCoroutine(getKilled());
    }
    IEnumerator getKilled()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
}