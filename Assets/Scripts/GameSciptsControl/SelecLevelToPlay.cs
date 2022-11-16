using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecLevelToPlay : MonoBehaviour
{
    public void ChargeFirstLevel()
    {
        Time.timeScale = 1f;
        AudioManager.obj.playUIClick();
        SceneManager.LoadScene("Level1");
    }

    public void ChargeSecondLevel()
    {
        Time.timeScale = 1f;
        AudioManager.obj.playUIClick();
        SceneManager.LoadScene("Level2");
    }
    public void ChargeThirdLevel()
    {
        Time.timeScale = 1f;
        AudioManager.obj.playUIClick();
        SceneManager.LoadScene("Level3");
    }
}
