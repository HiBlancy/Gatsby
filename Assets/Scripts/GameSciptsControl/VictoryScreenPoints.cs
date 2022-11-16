using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryScreenPoints : MonoBehaviour
{
    [SerializeField] GameObject highscore1;
    [SerializeField] GameObject highscore2;
    [SerializeField] GameObject highscore3;

    int level1Complete;
    int level2Complete;
    int level3Complete;

    void Start()
    {
        level1Complete = PlayerPrefs.GetInt("HighscoreLevel1");
        level2Complete = PlayerPrefs.GetInt("HighscoreLevel2");
        level3Complete = PlayerPrefs.GetInt("HighscoreLevel3");
    }

    void Update()
    {
        highscore1.GetComponent<Text>().text = "" + level1Complete;

        highscore2.GetComponent<Text>().text = "" + level2Complete;

        highscore3.GetComponent<Text>().text = "" + level3Complete;
    }
}