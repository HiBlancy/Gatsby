using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class PlayerLives : MonoBehaviour
{
    public static PlayerLives obj { get; private set; }
    Animator animator;
    public int lives = 3;

    bool isImmune = false;
    float immuneTimeCnt = 0f;
    float immuneTime = 1f;
    SpriteRenderer spriteRenderer;

    [SerializeField] GameObject DeadPanel;

    void Awake()
    {
        if (obj != null && obj != this)
            Destroy(this);
        else
            obj = this;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(isImmune)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;

            immuneTimeCnt -= Time.deltaTime;

            if(immuneTimeCnt <= 0)
            {
                isImmune = false;
                spriteRenderer.enabled = true;
            }
        }
    }

    void goImmune()
    {
        isImmune = true;
        immuneTimeCnt = immuneTime;
    }

    public void TakeDamage()
    {
        animator.SetTrigger("HurtedCat");
        lives--;
        AudioManager.obj.playPlayerHit();
        UIManager.obj.updateLives();

        goImmune();

        if (lives <= 0)
        {
            animator.SetTrigger("DeathCat");
            DeadPanel.SetActive(true);
            gameObject.GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<PlayerJump>().enabled = false;
        }
    }

    public void addLive()
    {
        lives++;

        if (lives > Game.obj.maxLives)
            lives = Game.obj.maxLives;

        UIManager.obj.updateLives();
    }
}
