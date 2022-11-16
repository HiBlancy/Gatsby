using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager obj;

    [SerializeField] AudioClip fish;
    [SerializeField] AudioClip jump;
    [SerializeField] AudioClip enemyHit;
    [SerializeField] AudioClip playerHit;
    [SerializeField] AudioClip UIClick;

    AudioSource audioSource;

    private void Awake()
    {
        obj = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void playFish() { playSound(fish); }

    public void playJump() { playSound(jump); }

    public void playEnemyHit() { playSound(enemyHit); }

    public void playPlayerHit() { playSound(playerHit); }

    public void playUIClick() { playSound(UIClick); }

    public void playSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    private void OnDestroy()
    {
        obj = null;
    }
}