using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlock : MonoBehaviour
{
    [SerializeField] GameObject lock1;
    [SerializeField] GameObject lock2;

    int level1Complete;
    int level2Complete;


    void Start()
    {
        level1Complete = PlayerPrefs.GetInt("SavedLevel1");
        level2Complete = PlayerPrefs.GetInt("SavedLevel2");
    }


    void Update()
    {
        if(level1Complete == 0)
        {
            lock1.SetActive(true);
            lock2.SetActive(true);
        }

        if(level1Complete == 1)
        {
            lock1.SetActive(false);
            lock2.SetActive(true);
        }

        if (level2Complete == 1)
        {
            lock2.SetActive(false);
        }
    }
}